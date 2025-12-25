using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class UnitConvertor
    {
        // a. Convert yards to feet
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        // b. Convert feet to yards
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        // c. Convert meters to inches
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        // d. Convert inches to meters
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        // e. Convert inches to centimeters
        public static double ConvertInchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }

        // Main method
        static void Main(string[] args)
        {
            Console.Write("Enter value in yards: ");
            double yards = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yards to Feet: " + ConvertYardsToFeet(yards));

            Console.Write("Enter value in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Feet to Yards: " + ConvertFeetToYards(feet));

            Console.Write("Enter value in meters: ");
            double meters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Meters to Inches: " + ConvertMetersToInches(meters));

            Console.Write("Enter value in inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inches to Meters: " + ConvertInchesToMeters(inches));
            Console.WriteLine("Inches to Centimeters: " + ConvertInchesToCentimeters(inches));
        }
    }
}
