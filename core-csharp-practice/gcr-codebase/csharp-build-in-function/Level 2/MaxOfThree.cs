using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class MaxOfThree
    {
        static int FindMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static void Main()
        {
            Console.Write("Enter three numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maximum: " + FindMax(a, b, c));
        }
    }
}
