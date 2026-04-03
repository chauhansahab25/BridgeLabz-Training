using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class DateComparison
    {
        static void Main()
        {
            Console.Write("Enter first date (yyyy-MM-dd): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter second date (yyyy-MM-dd): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            int result = DateTime.Compare(date1, date2);

            if (result < 0)
                Console.WriteLine("First date is BEFORE second date");
            else if (result > 0)
                Console.WriteLine("First date is AFTER second date");
            else
                Console.WriteLine("Both dates are the SAME");
        }
    }
}
