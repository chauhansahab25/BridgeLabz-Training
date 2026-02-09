using System;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public class DoctorMenu : IDoctorOperations
    {
        public void AddDoctorProfile()
        {
            Console.Clear();
            DoctorUtility.DisplayHeader("Add Doctor Profile");

            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Specialty ID: ");
            int specialtyId = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone (10 digits): ");
            string phone = Console.ReadLine();
            Console.Write("Enter Consultation Fee: ");
            decimal fee = decimal.Parse(Console.ReadLine());

            SqlConnection conn = DoctorConnection.GetConnection();

            string insertQuery = "INSERT INTO doctors (name, specialty_id, phone, consultation_fee) VALUES (@name, @specialtyId, @phone, @fee)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@specialtyId", specialtyId);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@fee", fee);

            cmd.ExecuteNonQuery();
            Console.WriteLine("\nDoctor profile added successfully!");
            conn.Close();

            DoctorUtility.PressAnyKey();
        }

        public void AssignUpdateDoctorSpecialty()
        {
            Console.Clear();
            DoctorUtility.DisplayHeader("Assign/Update Doctor Specialty");

            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            SqlConnection conn = DoctorConnection.GetConnection();

            string displayQuery = "SELECT specialty_id, specialty_name FROM specialties";
            SqlCommand displayCmd = new SqlCommand(displayQuery, conn);
            SqlDataReader reader = displayCmd.ExecuteReader();

            Console.WriteLine("\nAvailable Specialties:");
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + ". " + reader.GetString(1));
            }
            reader.Close();

            Console.Write("\nEnter New Specialty ID: ");
            int specialtyId = int.Parse(Console.ReadLine());

            SqlTransaction transaction = conn.BeginTransaction();

            string updateQuery = "UPDATE doctors SET specialty_id = @specialtyId WHERE doctor_id = @doctorId";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
            updateCmd.Parameters.AddWithValue("@specialtyId", specialtyId);
            updateCmd.Parameters.AddWithValue("@doctorId", doctorId);

            updateCmd.ExecuteNonQuery();
            transaction.Commit();

            Console.WriteLine("\nDoctor specialty updated successfully!");
            conn.Close();

            DoctorUtility.PressAnyKey();
        }

        public void ViewDoctorsBySpecialty()
        {
            Console.Clear();
            DoctorUtility.DisplayHeader("View Doctors by Specialty");

            Console.WriteLine("Enter Specialty Name ('Cardiology','Neurology', 'Pediatrics', 'Orthopedics', 'Dermatology'): ");
            string specialtyName = Console.ReadLine();

            SqlConnection conn = DoctorConnection.GetConnection();

            string query = "SELECT d.doctor_id, d.name, d.phone, d.consultation_fee FROM doctors d JOIN specialties s ON d.specialty_id = s.specialty_id WHERE s.specialty_name = @specialtyName AND d.is_active = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@specialtyName", specialtyName);

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nDoctor ID: " + reader.GetInt32(0));
                Console.WriteLine("Name: " + reader.GetString(1));
                Console.WriteLine("Phone: " + reader.GetString(2));
                Console.WriteLine("Consultation Fee: " + reader.GetDecimal(3));
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo doctors found for this specialty.");
            }

            reader.Close();
            conn.Close();
            DoctorUtility.PressAnyKey();
        }

        public void DeactivateDoctorProfile()
        {
            Console.Clear();
            DoctorUtility.DisplayHeader("Deactivate Doctor Profile");

            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            SqlConnection conn = DoctorConnection.GetConnection();

            string checkQuery = "SELECT COUNT(*) FROM appointments WHERE doctor_id = @doctorId AND appointment_date > GETDATE() AND status = 'SCHEDULED'";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@doctorId", doctorId);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                Console.WriteLine("\nCannot deactivate. Doctor has " + count + " future appointments.");
                conn.Close();
                DoctorUtility.PressAnyKey();
                return;
            }

            string updateQuery = "UPDATE doctors SET is_active = 0 WHERE doctor_id = @doctorId";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@doctorId", doctorId);

            updateCmd.ExecuteNonQuery();
            Console.WriteLine("\nDoctor profile deactivated successfully!");
            conn.Close();

            DoctorUtility.PressAnyKey();
        }

        public void ShowDoctorMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("   DOCTOR MANAGEMENT SYSTEM");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("1. Add Doctor Profile");
                Console.WriteLine("2. Assign/Update Doctor Specialty");
                Console.WriteLine("3. View Doctors by Specialty");
                Console.WriteLine("4. Deactivate Doctor Profile");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddDoctorProfile();
                }
                else if (choice == "2")
                {
                    AssignUpdateDoctorSpecialty();
                }
                else if (choice == "3")
                {
                    ViewDoctorsBySpecialty();
                }
                else if (choice == "4")
                {
                    DeactivateDoctorProfile();
                }
                else if (choice == "0")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice!");
                    DoctorUtility.PressAnyKey();
                }
            }
        }
    }
}
