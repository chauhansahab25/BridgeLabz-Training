using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class Fibonacci
    {
        static void GenerateFibonacci(int terms)
        {
            int a = 0, b = 1;

            for (int i = 0; i < terms; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        static void Main()
        {
            Console.Write("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            GenerateFibonacci(terms);
        }
    }
}
