using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class CheckNumPositiveNegative
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");

            int num= Convert.ToInt32(Console.ReadLine());

            int result= CheckNumber(num);

            if (result == 1)
            {
                Console.WriteLine("Number is Positive");
            }

            else if (result == -1)
            {
                Console.WriteLine("Number is Negative");
            }

            else {
                Console.WriteLine("Zero");
            }


        }

        static int CheckNumber(int n)
        {
            if (n > 0)
                return 1;      // num is Positive


            else if (n < 0)
                return -1;     // num is Negative


            else
                return 0;     // zero
        }
    }
}
