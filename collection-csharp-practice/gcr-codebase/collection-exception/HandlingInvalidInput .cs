using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Exception
{
    public class HandlingInvalidInput
    {
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Invalid input: Amount and rate must be positive");
            }

           
            return (amount * rate * years) / 100;
        }

       public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter amount: ");
                double am = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter rate: ");
                double ra = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter years: ");
                int ye = Convert.ToInt32(Console.ReadLine());

                double interest = CalculateInterest(am, ra, ye);
                Console.WriteLine("Calculated Interest: " + interest);
            }



            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
