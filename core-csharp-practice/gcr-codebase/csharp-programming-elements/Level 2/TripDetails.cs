using System;
class TripDetails
{
     static void Main(string[] args)
    {
        // Taking string inputs
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        
        Console.Write("Enter distance from start city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from via city to destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter total time taken (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        
        Console.WriteLine("The results of the trip are: " +totalDistance + " miles, "+ timeTaken + " hours, and " + averageSpeed + " miles/hour");
    }
}
