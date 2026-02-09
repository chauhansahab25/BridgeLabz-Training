using System;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public class BillingMenu : IBillingOperations
    {
        public void GenerateBillForVisit()
        {
            Console.Clear();
            BillingUtility.DisplayHeader("Generate Bill for Visit");

            Console.Write("Enter Visit ID: ");
            int visitId = int.Parse(Console.ReadLine());
            Console.Write("Enter Additional Charges: ");
            decimal additionalCharges = decimal.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string getFeeQuery = "SELECT d.consultation_fee FROM visits v JOIN doctors d ON v.doctor_id = d.doctor_id WHERE v.visit_id = @visitId";
            SqlCommand getFeeCmd = new SqlCommand(getFeeQuery, conn);
            getFeeCmd.Parameters.AddWithValue("@visitId", visitId);
            decimal consultationFee = (decimal)getFeeCmd.ExecuteScalar();

            decimal totalAmount = consultationFee + additionalCharges;

            string insertQuery = "INSERT INTO bills (visit_id, consultation_fee, additional_charges, total_amount, payment_status) VALUES (@visitId, @consultationFee, @additionalCharges, @totalAmount, 'UNPAID')";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@visitId", visitId);
            cmd.Parameters.AddWithValue("@consultationFee", consultationFee);
            cmd.Parameters.AddWithValue("@additionalCharges", additionalCharges);
            cmd.Parameters.AddWithValue("@totalAmount", totalAmount);

            cmd.ExecuteNonQuery();
            Console.WriteLine("\nBill generated successfully!");
            Console.WriteLine("Total Amount: " + totalAmount);
            conn.Close();

            BillingUtility.PressAnyKey();
        }

        public void RecordPayment()
        {
            Console.Clear();
            BillingUtility.DisplayHeader("Record Payment");

            Console.Write("Enter Bill ID: ");
            int billId = int.Parse(Console.ReadLine());
            Console.Write("Enter Payment Mode (Cash/Card/UPI): ");
            string paymentMode = Console.ReadLine();

            SqlConnection conn = DatabaseConnection.GetConnection();
            SqlTransaction transaction = conn.BeginTransaction();

            string updateBillQuery = "UPDATE bills SET payment_status = 'PAID', payment_date = GETDATE(), payment_mode = @paymentMode WHERE bill_id = @billId";
            SqlCommand updateCmd = new SqlCommand(updateBillQuery, conn, transaction);
            updateCmd.Parameters.AddWithValue("@paymentMode", paymentMode);
            updateCmd.Parameters.AddWithValue("@billId", billId);
            updateCmd.ExecuteNonQuery();

            string getAmountQuery = "SELECT total_amount FROM bills WHERE bill_id = @billId";
            SqlCommand getAmountCmd = new SqlCommand(getAmountQuery, conn, transaction);
            getAmountCmd.Parameters.AddWithValue("@billId", billId);
            decimal amount = (decimal)getAmountCmd.ExecuteScalar();

            string insertTransactionQuery = "INSERT INTO payment_transactions (bill_id, amount, payment_mode, transaction_date) VALUES (@billId, @amount, @paymentMode, GETDATE())";
            SqlCommand transactionCmd = new SqlCommand(insertTransactionQuery, conn, transaction);
            transactionCmd.Parameters.AddWithValue("@billId", billId);
            transactionCmd.Parameters.AddWithValue("@amount", amount);
            transactionCmd.Parameters.AddWithValue("@paymentMode", paymentMode);
            transactionCmd.ExecuteNonQuery();

            transaction.Commit();
            Console.WriteLine("\nPayment recorded successfully!");
            conn.Close();

            BillingUtility.PressAnyKey();
        }

        public void ViewOutstandingBills()
        {
            Console.Clear();
            BillingUtility.DisplayHeader("View Outstanding Bills");

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT b.bill_id, p.name AS patient_name, b.total_amount, b.payment_status, COUNT(b.bill_id) OVER (PARTITION BY b.visit_id) as bill_count, SUM(b.total_amount) OVER (PARTITION BY v.patient_id) as patient_total FROM bills b JOIN visits v ON b.visit_id = v.visit_id JOIN patients p ON v.patient_id = p.patient_id WHERE b.payment_status = 'UNPAID'";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nBill ID: " + reader.GetInt32(0));
                Console.WriteLine("Patient: " + reader.GetString(1));
                Console.WriteLine("Amount: " + reader.GetDecimal(2));
                Console.WriteLine("Status: " + reader.GetString(3));
                Console.WriteLine("Patient Total Outstanding: " + reader.GetDecimal(5));
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo outstanding bills.");
            }

            reader.Close();
            conn.Close();
            BillingUtility.PressAnyKey();
        }

        public void GenerateRevenueReport()
        {
            Console.Clear();
            BillingUtility.DisplayHeader("Generate Revenue Report");

            Console.Write("Enter Start Date (yyyy-mm-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter End Date (yyyy-mm-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            SqlConnection conn = DatabaseConnection.GetConnection();

            string query = "SELECT CONVERT(DATE, b.payment_date) as payment_date, d.name AS doctor_name, s.specialty_name, SUM(b.total_amount) as total_revenue FROM bills b JOIN visits v ON b.visit_id = v.visit_id JOIN doctors d ON v.doctor_id = d.doctor_id JOIN specialties s ON d.specialty_id = s.specialty_id WHERE b.payment_status = 'PAID' AND b.payment_date BETWEEN @startDate AND @endDate GROUP BY CONVERT(DATE, b.payment_date), d.name, s.specialty_name HAVING SUM(b.total_amount) > 0 ORDER BY payment_date";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);

            SqlDataReader reader = cmd.ExecuteReader();

            bool found = false;
            decimal grandTotal = 0;
            while (reader.Read())
            {
                found = true;
                Console.WriteLine("\nDate: " + reader.GetDateTime(0).ToString("yyyy-MM-dd"));
                Console.WriteLine("Doctor: " + reader.GetString(1));
                Console.WriteLine("Specialty: " + reader.GetString(2));
                Console.WriteLine("Revenue: " + reader.GetDecimal(3));
                grandTotal += reader.GetDecimal(3);
                Console.WriteLine("-----------------------------------");
            }

            if (!found)
            {
                Console.WriteLine("\nNo revenue data for this period.");
            }
            else
            {
                Console.WriteLine("\nGrand Total Revenue: " + grandTotal);
            }

            reader.Close();
            conn.Close();
            BillingUtility.PressAnyKey();
        }

        public void ShowBillingMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("   BILLING MANAGEMENT");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("1. Generate Bill for Visit");
                Console.WriteLine("2. Record Payment");
                Console.WriteLine("3. View Outstanding Bills");
                Console.WriteLine("4. Generate Revenue Report");
                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    GenerateBillForVisit();
                }
                else if (choice == "2")
                {
                    RecordPayment();
                }
                else if (choice == "3")
                {
                    ViewOutstandingBills();
                }
                else if (choice == "4")
                {
                    GenerateRevenueReport();
                }
                else if (choice == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice!");
                    BillingUtility.PressAnyKey();
                }
            }
        }
    }
}
