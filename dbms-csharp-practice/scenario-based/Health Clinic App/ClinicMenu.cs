using System;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public class ClinicMenu : IClinicOperations
    {
        public void RegisterNewPatient()
        {
            Console.Clear();
            Console.WriteLine("=== Register New Patient ===");
            Console.WriteLine();

            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Phone (10 digits): ");
            string phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Blood Group: ");
            string bloodGroup = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || phone.Length != 10 || !email.Contains("@"))
            {
                Console.WriteLine("\nInvalid input. Please check all fields.");
                Utility.PressAnyKey();
                return;
            }

            SqlConnection conn = DatabaseConnection.GetConnection();

            string checkQuery = "SELECT COUNT(*) FROM patients WHERE phone = @phone OR email = @email";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@phone", phone);
            checkCmd.Parameters.AddWithValue("@email", email);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                Console.WriteLine("\nPatient with this phone or email already exists.");
                conn.Close();
                Utility.PressAnyKey();
                return;
            }

            string insertQuery = "INSERT INTO patients (name, dob, phone, email, address, blood_group) VALUES (@name, @dob, @phone, @email, @address, @bloodGroup)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@bloodGroup", bloodGroup);

            cmd.ExecuteNonQuery();
            Console.WriteLine("\nPatient registered successfully!");
            conn.Close();

            Utility.PressAnyKey();
        }

        public void UpdatePatientInformation()
        {
            Console.Clear();
            Console.WriteLine("=== Update Patient Information ===");
            Console.WriteLine();

            Console.Write("Enter Patient ID or Phone: ");
            string search = Console.ReadLine();

            SqlConnection conn = DatabaseConnection.GetConnection();

            string searchQuery = "SELECT * FROM patients WHERE patient_id = @search OR phone = @search";
            SqlCommand searchCmd = new SqlCommand(searchQuery, conn);
            searchCmd.Parameters.AddWithValue("@search", search);
            SqlDataReader reader = searchCmd.ExecuteReader();

            if (!reader.Read())
            {
                Console.WriteLine("\nPatient not found.");
                reader.Close();
                conn.Close();
                Utility.PressAnyKey();
                return;
            }

            int patientId = reader.GetInt32(0);
            Console.WriteLine("\nCurrent Details:");
            Console.WriteLine("Name: " + reader.GetString(1));
            Console.WriteLine("DOB: " + reader.GetDateTime(2).ToString("yyyy-MM-dd"));
            Console.WriteLine("Phone: " + reader.GetString(3));
            Console.WriteLine("Email: " + reader.GetString(4));
            Console.WriteLine("Address: " + reader.GetString(5));
            Console.WriteLine("Blood Group: " + reader.GetString(6));
            reader.Close();

            Console.WriteLine();
            Console.Write("Enter New Name (or press Enter to skip): ");
            string name = Console.ReadLine();
            Console.Write("Enter New Phone (or press Enter to skip): ");
            string phone = Console.ReadLine();
            Console.Write("Enter New Email (or press Enter to skip): ");
            string email = Console.ReadLine();
            Console.Write("Enter New Address (or press Enter to skip): ");
            string address = Console.ReadLine();
            Console.Write("Enter New Blood Group (or press Enter to skip): ");
            string bloodGroup = Console.ReadLine();

            string updateQuery = "UPDATE patients SET ";
            bool first = true;

            if (!string.IsNullOrEmpty(name))
            {
                updateQuery += "name = @name";
                first = false;
            }
            if (!string.IsNullOrEmpty(phone))
            {
                if (!first) updateQuery += ", ";
                updateQuery += "phone = @phone";
                first = false;
            }
            if (!string.IsNullOrEmpty(email))
            {
                if (!first) updateQuery += ", ";
                updateQuery += "email = @email";
                first = false;
            }
            if (!string.IsNullOrEmpty(address))
            {
                if (!first) updateQuery += ", ";
                updateQuery += "address = @address";
                first = false;
            }
            if (!string.IsNullOrEmpty(bloodGroup))
            {
                if (!first) updateQuery += ", ";
                updateQuery += "blood_group = @bloodGroup";
                first = false;
            }

            if (first)
            {
                Console.WriteLine("\nNo fields to update.");
                conn.Close();
                Utility.PressAnyKey();
                return;
            }

            updateQuery += " WHERE patient_id = @patientId";

            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@patientId", patientId);
            if (!string.IsNullOrEmpty(name)) updateCmd.Parameters.AddWithValue("@name", name);
            if (!string.IsNullOrEmpty(phone)) updateCmd.Parameters.AddWithValue("@phone", phone);
            if (!string.IsNullOrEmpty(email)) updateCmd.Parameters.AddWithValue("@email", email);
            if (!string.IsNullOrEmpty(address)) updateCmd.Parameters.AddWithValue("@address", address);
            if (!string.IsNullOrEmpty(bloodGroup)) updateCmd.Parameters.AddWithValue("@bloodGroup", bloodGroup);

            updateCmd.ExecuteNonQuery();
            Console.WriteLine("\nPatient information updated successfully!");
            conn.Close();

            Utility.PressAnyKey();
        }

        public void SearchPatientRecords()
        {
            Console.Clear();
            Utility.DisplayHeader("Search Patient Records");

            Console.Write("Enter search (Name/ID/Phone): ");
            string search = Console.ReadLine();

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT * FROM patients WHERE name LIKE @search OR patient_id = @id OR phone = @search";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            int id;
            if (int.TryParse(search, out id))
                cmd.Parameters.AddWithValue("@id", id);
            else
                cmd.Parameters.AddWithValue("@id", 0);

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nPatient ID: " + reader.GetInt32(0));
                Console.WriteLine("Name: " + reader.GetString(1));
                Console.WriteLine("DOB: " + reader.GetDateTime(2).ToString("yyyy-MM-dd"));
                Console.WriteLine("Phone: " + reader.GetString(3));
                Console.WriteLine("Email: " + reader.GetString(4));
                Console.WriteLine("Address: " + reader.GetString(5));
                Console.WriteLine("Blood Group: " + reader.GetString(6));
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo patients found.");
            }

            reader.Close();
            conn.Close();
            Utility.PressAnyKey();
        }

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("   HEALTH CLINIC MANAGEMENT SYSTEM");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("1. Register New Patient");
                Console.WriteLine("2. Update Patient Information");
                Console.WriteLine("3. Search Patient Records");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    RegisterNewPatient();
                }
                else if (choice == "2")
                {
                    UpdatePatientInformation();
                }
                else if (choice == "3")
                {
                    SearchPatientRecords();
                }
                else if (choice == "0")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice!");
                    Utility.PressAnyKey();
                }
            }
        }
    }
}
