using System;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public class AppointmentMenu : IAppointmentOperations
    {
        public void BookNewAppointment()
        {
            Console.Clear();
            AppointmentUtility.DisplayHeader("Book New Appointment");

            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());
            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());
            Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Appointment Time (HH:mm): ");
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string checkQuery = "SELECT COUNT(*) FROM appointments WHERE doctor_id = @doctorId AND appointment_date = @date AND appointment_time = @time";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@doctorId", doctorId);
            checkCmd.Parameters.AddWithValue("@date", date);
            checkCmd.Parameters.AddWithValue("@time", time);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                Console.WriteLine("\nSlot not available.");
                conn.Close();
                AppointmentUtility.PressAnyKey();
                return;
            }

            string insertQuery = "INSERT INTO appointments (patient_id, doctor_id, appointment_date, appointment_time, status) VALUES (@patientId, @doctorId, @date, @time, 'SCHEDULED')";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@patientId", patientId);
            cmd.Parameters.AddWithValue("@doctorId", doctorId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);

            cmd.ExecuteNonQuery();
            Console.WriteLine("\nAppointment booked successfully!");
            conn.Close();

            AppointmentUtility.PressAnyKey();
        }

        public void CheckDoctorAvailability()
        {
            Console.Clear();
            AppointmentUtility.DisplayHeader("Check Doctor Availability");

            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());
            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT appointment_time, COUNT(*) as bookings FROM appointments WHERE doctor_id = @doctorId AND appointment_date = @date GROUP BY appointment_time";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@doctorId", doctorId);
            cmd.Parameters.AddWithValue("@date", date);

            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nBooked Slots:");
            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("Time: " + reader.GetTimeSpan(0) + " - Bookings: " + reader.GetInt32(1));
            }

            if (!found)
            {
                Console.WriteLine("No bookings for this date.");
            }

            reader.Close();
            conn.Close();
            AppointmentUtility.PressAnyKey();
        }

        public void CancelAppointment()
        {
            Console.Clear();
            AppointmentUtility.DisplayHeader("Cancel Appointment");

            Console.Write("Enter Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();
            SqlTransaction transaction = conn.BeginTransaction();

            string updateQuery = "UPDATE appointments SET status = 'CANCELLED' WHERE appointment_id = @appointmentId";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
            updateCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            updateCmd.ExecuteNonQuery();

            string auditQuery = "INSERT INTO appointment_audit (appointment_id, action, action_date) VALUES (@appointmentId, 'CANCELLED', GETDATE())";
            SqlCommand auditCmd = new SqlCommand(auditQuery, conn, transaction);
            auditCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            auditCmd.ExecuteNonQuery();

            transaction.Commit();
            Console.WriteLine("\nAppointment cancelled successfully!");
            conn.Close();

            AppointmentUtility.PressAnyKey();
        }

        public void RescheduleAppointment()
        {
            Console.Clear();
            AppointmentUtility.DisplayHeader("Reschedule Appointment");

            Console.Write("Enter Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());
            Console.Write("Enter New Date (yyyy-mm-dd): ");
            DateTime newDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter New Time (HH:mm): ");
            TimeSpan newTime = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Enter New Doctor ID (or press Enter to keep same): ");
            string doctorInput = Console.ReadLine();

            SqlConnection conn = DatabaseConnection.GetConnection();

            string getQuery = "SELECT doctor_id FROM appointments WHERE appointment_id = @appointmentId";
            SqlCommand getCmd = new SqlCommand(getQuery, conn);
            getCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            int doctorId = (int)getCmd.ExecuteScalar();

            if (!string.IsNullOrEmpty(doctorInput))
            {
                doctorId = int.Parse(doctorInput);
            }

            string checkQuery = "SELECT COUNT(*) FROM appointments WHERE doctor_id = @doctorId AND appointment_date = @date AND appointment_time = @time AND appointment_id != @appointmentId";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@doctorId", doctorId);
            checkCmd.Parameters.AddWithValue("@date", newDate);
            checkCmd.Parameters.AddWithValue("@time", newTime);
            checkCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                Console.WriteLine("\nSlot not available. Rolling back.");
                conn.Close();
                AppointmentUtility.PressAnyKey();
                return;
            }

            SqlTransaction transaction = conn.BeginTransaction();

            string updateQuery = "UPDATE appointments SET appointment_date = @date, appointment_time = @time, doctor_id = @doctorId WHERE appointment_id = @appointmentId";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
            updateCmd.Parameters.AddWithValue("@date", newDate);
            updateCmd.Parameters.AddWithValue("@time", newTime);
            updateCmd.Parameters.AddWithValue("@doctorId", doctorId);
            updateCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            updateCmd.ExecuteNonQuery();

            transaction.Commit();
            Console.WriteLine("\nAppointment rescheduled successfully!");
            conn.Close();

            AppointmentUtility.PressAnyKey();
        }

        public void ViewDailyAppointmentSchedule()
        {
            Console.Clear();
            AppointmentUtility.DisplayHeader("View Daily Appointment Schedule");

            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT a.appointment_id, a.appointment_time, p.name AS patient_name, d.name AS doctor_name, a.status FROM appointments a JOIN patients p ON a.patient_id = p.patient_id JOIN doctors d ON a.doctor_id = d.doctor_id WHERE a.appointment_date = @date ORDER BY a.appointment_time";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@date", date);

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nAppointment ID: " + reader.GetInt32(0));
                Console.WriteLine("Time: " + reader.GetTimeSpan(1));
                Console.WriteLine("Patient: " + reader.GetString(2));
                Console.WriteLine("Doctor: " + reader.GetString(3));
                Console.WriteLine("Status: " + reader.GetString(4));
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo appointments for this date.");
            }

            reader.Close();
            conn.Close();
            AppointmentUtility.PressAnyKey();
        }

        public void ShowAppointmentMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("   APPOINTMENT MANAGEMENT");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("1. Book New Appointment");
                Console.WriteLine("2. Check Doctor Availability");
                Console.WriteLine("3. Cancel Appointment");
                Console.WriteLine("4. Reschedule Appointment");
                Console.WriteLine("5. View Daily Appointment Schedule");
                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BookNewAppointment();
                }
                else if (choice == "2")
                {
                    CheckDoctorAvailability();
                }
                else if (choice == "3")
                {
                    CancelAppointment();
                }
                else if (choice == "4")
                {
                    RescheduleAppointment();
                }
                else if (choice == "5")
                {
                    ViewDailyAppointmentSchedule();
                }
                else if (choice == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice!");
                    AppointmentUtility.PressAnyKey();
                }
            }
        }
    }
}
