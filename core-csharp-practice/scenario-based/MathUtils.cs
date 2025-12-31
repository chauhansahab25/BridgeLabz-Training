using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.scenariobased
{
    public class MathUtils
    {
        static void Main(string[] args)
        {
            bool resumeExecution = true;
            while (resumeExecution)
            {

                Console.WriteLine("Choose a option: ");
                Console.WriteLine("1. Find Factorial of a number");
                Console.WriteLine("2. Find if a number is prime?");
                Console.WriteLine("3. Find the GCD of a number");
                Console.WriteLine("4. Find the Fibonacci of a number");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the number: ");
                        int val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Factorial of " + val + ": " +  MathUtils.GetFactorial(val));
                        break;

                    case "2":
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Is" + num + "Prime? " + MathUtils.IsPrimeNumber(num));
                        break;

                    case "3":
                        Console.WriteLine("Enter the values: ");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("GCD of " + (first, second) + ": " + MathUtils.FindGCD(first, second));
                        break;

                    case "4":
                        Console.WriteLine("Enter the number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fibonacci of " + n + ": " + MathUtils.GetFibonacciValue(n));
                        break;

                    case "5":
                        resumeExecution = false;
                        break;

                    default:
                        Console.WriteLine("Choose a valid option");
                        break;
                }
            }
        }
        
        

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
        public static long GetFibonacciValue(int n)// find nth value in the fibonacci sequence
        {
            if (n < 0)
                throw new ArgumentException("Index must be non-negative.");

            if (n == 0) return 0;
            if (n == 1) return 1;

            int prev = 0, current = 1 , nextTerm;
            for (int k = 2; k <= n; k++)
            {
                nextTerm = prev + current;
                prev = current;
                current = nextTerm;
            }
            return current;
        }
    }

    
}













               
        
    

