using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.scenariobased
{
       public class MathUtils
        {
            
            public static int GetFactorial(int val)// Calculates product of all positive integers up to n
        {
                if (val < 0)
                    throw new ArgumentException("Input cannot be negative.");

                int total = 1;
                for (int x = 1; x <= val; x++)
                {
                    total *= x;
                }
                return total;
            }        
            public static bool IsPrimeNumber(int num)
            {
                if (num <= 1) return false;               
                for (int j = 2; j <= Math.Sqrt(num); j++)//check up to the square root
            {
                    if (num % j == 0) return false;
                }
                return true;
            }
            public static int FindGCD(int first, int second)// Finds the GCD using the Euclidean algorithm
        {
                first = Math.Abs(first);
                second = Math.Abs(second);

                while (second != 0)
                {
                    int remainder = first % second;
                    first = second;
                    second = remainder;
                }
                return first;
            }
            public static long GetFibonacciValue(int position)// find nth value in the fibonacci sequence
        {
                if (position < 0)
                    throw new ArgumentException("Index must be non-negative.");

                if (position == 0) return 0;
                if (position == 1) return 1;

                long prev = 0, current = 1;
                for (int k = 2; k <= position; k++)
                {
                    long nextTerm = prev + current;
                    prev = current;
                    current = nextTerm;
                }
                return current;
            }
        }

        class ExecutionPoint
        {
            static void Main(string[] args)
            {
                Console.WriteLine($"Factorial (5): {MathUtils.GetFactorial(5)}");
                Console.WriteLine($"Is 7 Prime?: {MathUtils.IsPrimeNumber(7)}");
                Console.WriteLine($"GCD (48, 18): {MathUtils.FindGCD(48, 18)}");
                Console.WriteLine($"Fibonacci Pos 6: {MathUtils.GetFibonacciValue(6)}");
            }
        }
    
}
