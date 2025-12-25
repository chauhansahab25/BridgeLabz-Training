using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
     public class PointCalculations
    {
        static void Main()
        {
            // Take inputs for 2 points
            Console.WriteLine("Enter coordinates for Point 1:");
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter coordinates for Point 2:");
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            
            double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine("\nEuclidean Distance: {0:F2}", distance);

            /
            double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
            double slope = lineEquation[0];
            double yIntercept = lineEquation[1];

            Console.WriteLine("\nEquation of the line:");
            Console.WriteLine("y = {0:F2}x + {1:F2}", slope, yIntercept);

            Console.WriteLine("Slope (m): {0:F2}", slope);
            Console.WriteLine("Y-intercept (b): {0:F2}", yIntercept);
        }

        
        static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
        {
            
            double xDifference = x2 - x1;// distance = sqrt((x2-x1)^2 + (y2-y1)^2)
            double yDifference = y2 - y1;

            double xSquared = Math.Pow(xDifference, 2);
            double ySquared = Math.Pow(yDifference, 2);
            double distance = Math.Sqrt(xSquared + ySquared);

            return distance;
        }

        
        static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
        {
            
            double slope = (y2 - y1) / (x2 - x1);// Calculate slope: m = (y2 - y1) / (x2 - x1)

            
            double yIntercept = y1 - slope * x1;// Calculate y-intercept: b = y1 - m * x1

            double[] result = new double[2];// Return array with slope and y-intercept
            result[0] = slope;
            result[1] = yIntercept;

            return result;
        }
    }

}
}
