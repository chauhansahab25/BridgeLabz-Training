using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class RandomNumberAnalysis
    {
        // a. generate array of 4-digit random numbers
        public static int[] Generate4DigitRandomArray(int size)
        {
            int[] numbers = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                // 4-digit numbers range from 1000 to 9999
                numbers[i] = random.Next(1000, 10000);
            }

            return numbers;
        }

        // b. find average, minimum and maximum
        public static double[] FindAverageMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);
            }

            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }

        static void Main(string[] args)
        {
            // Generate 5 random 4-digit numbers
            int[] randomNumbers = Generate4DigitRandomArray(5);

            Console.WriteLine("Generated 4-digit random numbers:");
            foreach (int num in randomNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // Find average, min and max
            double[] result = FindAverageMinMax(randomNumbers);

            Console.WriteLine("Average value: " + result[0]);
            Console.WriteLine("Minimum value: " + result[1]);
            Console.WriteLine("Maximum value: " + result[2]);
        }
    }
}
