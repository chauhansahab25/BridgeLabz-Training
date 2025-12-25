uusing System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class LeapYearChecker
    {
        // check if a year is a leap year
        public static bool IsLeapYear(int year)
        {
            // Gregorian calendar 
            if (year < 1582)
            {
                return false;
            }

            // Leap year rules
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool result = IsLeapYear(year);

            if (result)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year");
            }
        }
    }
}
