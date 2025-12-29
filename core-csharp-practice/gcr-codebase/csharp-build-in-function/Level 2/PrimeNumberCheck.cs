using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class PrimeNumberCheck
    {
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;

            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrime(n) ? "Prime Number" : "Not a Prime Number");
        }
    }
}
