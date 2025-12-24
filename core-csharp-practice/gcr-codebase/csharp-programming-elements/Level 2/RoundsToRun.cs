using System;
class RoundsToRun
{
     static void Main(string[] args)
    {
        Console.Write("Enter side 1 of the triangular park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 of the triangular park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 of the triangular park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Perimeter of triangle
        double perimeter = side1 + side2 + side3;

        // Total distance = 5 km = 5000 meters
        double totalDistance = 5000;

        // Number of rounds
        double round = totalDistance / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " +round + " to complete 5 km");
    }
}
