using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    class SumOfNaturalNumbers
    {
        
        static int CalculateSum(int n)
        {
            int sum = 0;

            
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        static void Main()
        {
            
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer!");
                return;
            }

            
            int result = CalculateSum(n);

            
            Console.WriteLine("Sum of first {0} natural numbers = {1}", n, result);
        }
    }

}
