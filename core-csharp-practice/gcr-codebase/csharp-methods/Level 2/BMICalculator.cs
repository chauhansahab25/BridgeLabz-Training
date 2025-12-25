using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class BMICalculator
    {
        // calculate BMI
        public static double CalculateBMI(double weightKg, double heightCm)
        {
            double heightMeters = heightCm / 100;
            return weightKg / (heightMeters * heightMeters);
        }

        //  get BMI status
        public static string GetBMIStatus(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal";
            else if (bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }

        static void Main(string[] args)
        {
            double[,] data = new double[10, 3]; // weight, height, BMI
            string[] status = new string[10];

            // Input
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
                data[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
                data[i, 1] = Convert.ToDouble(Console.ReadLine());

                // Calculate BMI directly
                data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);

                // Get BMI status
                status[i] = GetBMIStatus(data[i, 2]);
            }

            // Output
            Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(data[i, 0] + "\t" +data[i, 1] + "\t" +Math.Round(data[i, 2], 2) + "\t" +status[i]);
            }
        }
    }
}
