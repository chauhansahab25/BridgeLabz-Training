using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class NumberChecker2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = GetCount(number);
            int[] digits = StoreDigits(number, count);

            int sum = GetSumOfDigits(digits);
            Console.WriteLine("Sum of digits: " + sum);

            double squareSum = GetSumOfSquares(digits);
            Console.WriteLine("Sum of squares of digits: " + squareSum);

            if (IsHarshad(number, sum))
                Console.WriteLine(number + " is a Harshad Number.");
            else
                Console.WriteLine(number + " is not a Harshad Number.");

            PrintFrequency(digits);
        }

        static int GetCount(int n)
        {
            int c = 0;
            while (n > 0)
            {
                n /= 10;
                c++;
            }
            return c;
        }

        static int[] StoreDigits(int n, int count)
        {
            int[] arr = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                arr[i] = n % 10;
                n /= 10;
            }
            return arr;
        }

        static int GetSumOfDigits(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }
            return sum;
        }

        static double GetSumOfSquares(int[] digits)
        {
            double sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += Math.Pow(digits[i], 2);
            }
            return sum;
        }

        static bool IsHarshad(int n, int sumOfDigits)
        {
            return (n % sumOfDigits == 0);
        }

        static void PrintFrequency(int[] digits)
        {
            // 2D array: Column 0 is digit (0-9), Column 1 is frequency
            int[,] freq = new int[10, 2];

            // Initialize digits
            for (int i = 0; i < 10; i++) freq[i, 0] = i;

            for (int i = 0; i < digits.Length; i++)
            {
                int d = digits[i];
                freq[d, 1]++;
            }

            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < 10; i++)
            {
                if (freq[i, 1] > 0)
                {
                    Console.WriteLine("Digit " + freq[i, 0] + ": " + freq[i, 1]);
                }
            }
        }
    }
}
