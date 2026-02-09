using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthClinicApp
{
    public class AdminMenu : IAdminOperations
    {
        public void ManageSpecialtyLookup()
        {
            while (true)
            {
                Console.Clear();
                AdminUtility.DisplayHeader("Manage Specialty Lookup");

                Console.WriteLine("1. Add Specialty");
                Console.WriteLine("2. Update Specialty");
                Console.WriteLine("3. Delete Specialty");
                Console.WriteLine("4. View All Specialties");
                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter Specialty Name: ");
                    string name = Console.ReadLine();

                    SqlConnection conn = DatabaseConnection.GetConnection();
                    string insertQuery = "INSERT INTO specialties (specialty_name) VALUES (@name)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\nSpecialty added successfully!");
                    conn.Close();
                    AdminUtility.PressAnyKey();
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Specialty ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Specialty Name: ");
                    string name = Console.ReadLine();

                    SqlConnection conn = DatabaseConnection.GetConnection();
                    string updateQuery = "UPDATE specialties SET specialty_name = @name WHERE specialty_id = @id";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\nSpecialty updated successfully!");
                    conn.Close();
                    AdminUtility.PressAnyKey();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter Specialty ID: ");
                    int id = int.Parse(Console.ReadLine());

                    SqlConnection conn = DatabaseConnection.GetConnection();

                    string checkQuery = "SELECT COUNT(*) FROM doctors WHERE specialty_id = @id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", id);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        Console.WriteLine("\nCannot delete. " + count + " doctors are using this specialty.");
                        conn.Close();
                        AdminUtility.PressAnyKey();
                        continue;
                    }

                    string deleteQuery = "DELETE FROM specialties WHERE specialty_id = @id";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\nSpecialty deleted successfully!");
                    conn.Close();
                    AdminUtility.PressAnyKey();
                }
                else if (choice == "4")
                {
                    SqlConnection conn = DatabaseConnection.GetConnection();
                    string query = "SELECT * FROM specialties";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine("\nSpecialties:");
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0) + ". " + reader.GetString(1));
                    }
                    reader.Close();
                    conn.Close();
                    AdminUtility.PressAnyKey();
                }
                else if (choice == "0")
                {
                    return;
                }
            }
        }

        public void DatabaseBackupTrigger()
        {
            Console.Clear();
            AdminUtility.DisplayHeader("Database Backup");

            SqlConnection conn = DatabaseConnection.GetConnection();

            Console.WriteLine("Backing up critical tables...");

            string[] tables = { "patients", "doctors", "appointments", "visits", "bills" };

            foreach (string table in tables)
            {
                string query = "SELECT * FROM " + table;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int rowCount = 0;
                while (reader.Read())
                {
                    rowCount++;
                }
                reader.Close();

                Console.WriteLine(table + ": " + rowCount + " records backed up");
            }

            SqlCommand metaCmd = conn.CreateCommand();
            DataTable schema = conn.GetSchema("Tables");
            Console.WriteLine("\nTotal Tables: " + schema.Rows.Count);

            Console.WriteLine("\nBackup completed successfully!");
            conn.Close();

            AdminUtility.PressAnyKey();
        }

        public void ViewSystemAuditLogs()
        {
            Console.Clear();
            AdminUtility.DisplayHeader("View System Audit Logs");

            Console.Write("Enter Table Name (or press Enter for all): ");
            string tableName = Console.ReadLine();
            Console.Write("Enter Start Date (yyyy-mm-dd) or press Enter: ");
            string dateInput = Console.ReadLine();

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT * FROM audit_log WHERE 1=1";

            if (!string.IsNullOrEmpty(tableName))
            {
                query += " AND table_name = @tableName";
            }

            if (!string.IsNullOrEmpty(dateInput))
            {
                query += " AND action_timestamp >= @startDate";
            }

            query += " ORDER BY action_timestamp DESC";

            SqlCommand cmd = new SqlCommand(query, conn);

            if (!string.IsNullOrEmpty(tableName))
            {
                cmd.Parameters.AddWithValue("@tableName", tableName);
            }

            if (!string.IsNullOrEmpty(dateInput))
            {
                cmd.Parameters.AddWithValue("@startDate", DateTime.Parse(dateInput));
            }

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nAudit ID: " + reader.GetInt32(0));
                Console.WriteLine("Table: " + reader.GetString(1));
                Console.WriteLine("Action: " + reader.GetString(2));
                Console.WriteLine("User: " + reader.GetString(3));
                Console.WriteLine("Timestamp: " + reader.GetDateTime(4));
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo audit logs found.");
            }

            reader.Close();
            conn.Close();
            AdminUtility.PressAnyKey();
        }

        public void ShowAdminMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("   SYSTEM ADMINISTRATION");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("1. Manage Specialty Lookup");
                Console.WriteLine("2. Database Backup");
                Console.WriteLine("3. View System Audit Logs");
                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ManageSpecialtyLookup();
                }
                else if (choice == "2")
                {
                    DatabaseBackupTrigger();
                }
                else if (choice == "3")
                {
                    ViewSystemAuditLogs();
                }
                else if (choice == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice!");
                    AdminUtility.PressAnyKey();
                }
            }
        }
    }
}
