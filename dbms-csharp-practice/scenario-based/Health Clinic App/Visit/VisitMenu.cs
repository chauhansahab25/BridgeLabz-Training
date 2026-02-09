using System;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public class VisitMenu : IVisitOperations
    {
        public void RecordPatientVisit()
        {
            Console.Clear();
            VisitUtility.DisplayHeader("Record Patient Visit");

            Console.Write("Enter Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());
            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());
            Console.Write("Enter Visit Date (yyyy-mm-dd): ");
            DateTime visitDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Diagnosis: ");
            string diagnosis = Console.ReadLine();
            Console.Write("Enter Notes: ");
            string notes = Console.ReadLine();

            SqlConnection conn = DatabaseConnection.GetConnection();
            SqlTransaction transaction = conn.BeginTransaction();

            string insertVisitQuery = "INSERT INTO visits (appointment_id, patient_id, doctor_id, visit_date, diagnosis, notes) VALUES (@appointmentId, @patientId, @doctorId, @visitDate, @diagnosis, @notes)";
            SqlCommand visitCmd = new SqlCommand(insertVisitQuery, conn, transaction);
            visitCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            visitCmd.Parameters.AddWithValue("@patientId", patientId);
            visitCmd.Parameters.AddWithValue("@doctorId", doctorId);
            visitCmd.Parameters.AddWithValue("@visitDate", visitDate);
            visitCmd.Parameters.AddWithValue("@diagnosis", diagnosis);
            visitCmd.Parameters.AddWithValue("@notes", notes);
            visitCmd.ExecuteNonQuery();

            string updateAppointmentQuery = "UPDATE appointments SET status = 'COMPLETED' WHERE appointment_id = @appointmentId";
            SqlCommand updateCmd = new SqlCommand(updateAppointmentQuery, conn, transaction);
            updateCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            updateCmd.ExecuteNonQuery();

            transaction.Commit();
            Console.WriteLine("\nVisit recorded successfully!");
            conn.Close();

            VisitUtility.PressAnyKey();
        }

        public void ViewPatientMedicalHistory()
        {
            Console.Clear();
            VisitUtility.DisplayHeader("View Patient Medical History");

            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT v.visit_date, d.name AS doctor_name, v.diagnosis, v.notes, p.medicine_name, p.dosage, p.duration FROM visits v JOIN doctors d ON v.doctor_id = d.doctor_id LEFT JOIN prescriptions p ON v.visit_id = p.visit_id WHERE v.patient_id = @patientId ORDER BY v.visit_date DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@patientId", patientId);

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nVisit Date: " + reader.GetDateTime(0).ToString("yyyy-MM-dd"));
                Console.WriteLine("Doctor: " + reader.GetString(1));
                Console.WriteLine("Diagnosis: " + reader.GetString(2));
                Console.WriteLine("Notes: " + reader.GetString(3));
                if (!reader.IsDBNull(4))
                {
                    Console.WriteLine("Medicine: " + reader.GetString(4));
                    Console.WriteLine("Dosage: " + reader.GetString(5));
                    Console.WriteLine("Duration: " + reader.GetString(6));
                }
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo medical history found.");
            }

            reader.Close();
            conn.Close();
            VisitUtility.PressAnyKey();
        }

        public void AddPrescriptionDetails()
        {
            Console.Clear();
            VisitUtility.DisplayHeader("Add Prescription Details");

            Console.Write("Enter Visit ID: ");
            int visitId = int.Parse(Console.ReadLine());
            Console.Write("How many medicines to add? ");
            int count = int.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string insertQuery = "INSERT INTO prescriptions (visit_id, medicine_name, dosage, duration) VALUES (@visitId, @medicineName, @dosage, @duration)";

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("\nMedicine " + i + ":");
                Console.Write("Medicine Name: ");
                string medicineName = Console.ReadLine();
                Console.Write("Dosage: ");
                string dosage = Console.ReadLine();
                Console.Write("Duration: ");
                string duration = Console.ReadLine();

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@visitId", visitId);
                cmd.Parameters.AddWithValue("@medicineName", medicineName);
                cmd.Parameters.AddWithValue("@dosage", dosage);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("\nPrescriptions added successfully!");
            conn.Close();

            VisitUtility.PressAnyKey();
        }

        public void ShowVisitMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("   VISIT MANAGEMENT");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("1. Record Patient Visit");
                Console.WriteLine("2. View Patient Medical History");
                Console.WriteLine("3. Add Prescription Details");
                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    RecordPatientVisit();
                }
                else if (choice == "2")
                {
                    ViewPatientMedicalHistory();
                }
                else if (choice == "3")
                {
                    AddPrescriptionDetails();
                }
                else if (choice == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice!");
                    VisitUtility.PressAnyKey();
                }
            }
        }
    }
}
