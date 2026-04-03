using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class GCDAndLCM
    {
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        static void Main()
        {
            Console.Write("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GCD: " + GCD(a, b));
            Console.WriteLine("LCM: " + LCM(a, b));
        }
    }
}
