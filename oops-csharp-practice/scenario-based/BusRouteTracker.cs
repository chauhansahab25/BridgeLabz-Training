using System;

namespace CG_Practice.oopsscenario
{
class BusRouteTracker
{
    static void Main()
    {
        double totalDistance = 0;  // keeps track of how far we've gone
        int stopNum = 1;
        
        Console.WriteLine("Bus Route Distance Tracker");
        Console.WriteLine("Starting journey...");
        
        while (true)  // keep going until passenger gets off
        {
            Console.WriteLine();
            Console.WriteLine("Stop " + stopNum + " coming up!");
            
            Console.Write("How far to this stop? (km): ");
            double dist = double.Parse(Console.ReadLine());
            
            totalDistance = totalDistance + dist;  // add distance
            
            Console.WriteLine("Total distance so far: " + totalDistance + " km");
            
            // ask passenger
            Console.Write("Want to get off here? (y/n): ");
            string answer = Console.ReadLine();
            
            if (answer == "y")
            {
                Console.WriteLine();
                Console.WriteLine("Getting off at stop " + stopNum);
                Console.WriteLine("Total trip: " + totalDistance + " km");
                Console.WriteLine("Thanks for riding!");
                break;  // stop the loop
            }
            
            Console.WriteLine("Continuing to next stop...");
            stopNum++;  // next stop number
        }
        
        Console.ReadKey();
    }
}
}
