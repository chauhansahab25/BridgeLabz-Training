using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.scenariobased
{
        class BillCreator
        {
            static void StartBill()
            {
                Console.WriteLine("Enter work details (Example: Logo Design - 3000 INR, Web Page - 4500 INR)");
                string userInput = Console.ReadLine();

                string[] workList = BreakInvoice(userInput);
                double finalSum = CalculateTotal(workList);

                Console.WriteLine("Final bill amount is " + finalSum);
            }

            static string[] BreakInvoice(string data)
            {
                string[] items = data.Split(',');

                Console.WriteLine("Bill Information");

                foreach (string item in items)
                {
                    string[] info = item.Split('-');
                    Console.WriteLine("Work : " + info[0].Trim() + " Cost " + info[1].Trim());
                }

                return items;
            }

            static double CalculateTotal(string[] itemList)
            {
                double sum = 0;

                foreach (string item in itemList)
                {
                    string[] details = item.Split('-');
                    string price = details[1].Replace("INR", "").Trim();
                    sum += int.Parse(price);
                }

                return sum;
            }

            static void Main(string[] args)
            {
                StartBill();
            }
        }
    
}
