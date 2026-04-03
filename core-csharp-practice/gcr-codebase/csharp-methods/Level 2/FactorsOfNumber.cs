using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class FactorsOfNumber
    {
        // find factors and return them as an array
        public static int[] FindFactors(int number)
        {
            int count = 0;

            // count factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            // Initialize array 
            int[] factors = new int[count];
            int index = 0;

            //store factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }

        // Find sum of factors
        public static int FindSum(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        //find product of factors
        public static long FindProduct(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }

        // find sum of squares of factors
        public static double FindSumOfSquares(int[] factors)
        {
            double sumOfSquares = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sumOfSquares += Math.Pow(factors[i], 2);
            }
            return sumOfSquares;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] factors = FindFactors(number);

            Console.WriteLine("Factors of " + number + ":");
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();

            int sum = FindSum(factors);
            long product = FindProduct(factors);
            double sumOfSquares = FindSumOfSquares(factors);

            Console.WriteLine("Sum of factors: " + sum);
            Console.WriteLine("Product of factors: " + product);
            Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
        }
    }

}
