using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    class SpringSeason
    {
        static bool IsSpring(int month, int day)
        {
            
            if (month == 4 || month == 5)
            {
                return true;
            }

            if (month == 3 && day >= 20)
            {
                return true;
            }

            if (month == 6 && day <= 20)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide month and day as command line arguments.");
                Console.WriteLine("Usage: SpringSeason <month> <day>");
                return;
            }

            int month, day;

            if (!int.TryParse(args[0], out month))
            {
                Console.WriteLine("Invalid month. Please enter a valid integer.");
                return;
            }

            if (!int.TryParse(args[1], out day))
            {
                Console.WriteLine("Invalid day. Please enter a valid integer.");
                return;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month. Month must be between 1 and 12.");
                return;
            }

            if (day < 1 || day > 31)
            {
                Console.WriteLine("Invalid day. Day must be between 1 and 31.");
                return;
            }

            bool isSpring = IsSpring(month, day);

            if (isSpring)
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
    }

}
