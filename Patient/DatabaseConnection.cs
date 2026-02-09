using System;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public class DatabaseConnection
    {
        private static string connectionString = "Server=localhost,1433;Database=HealthClinicDB;User Id=sa;Password=Glauniversity@123;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
