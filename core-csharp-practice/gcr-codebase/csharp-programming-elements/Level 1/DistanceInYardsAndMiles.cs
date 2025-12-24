using System;

class DistanceInYardsAndMiles
{
	static void Main()
	{
		
		Console.Write("Enter distance in feet :");

		int distanceInFeet = Convert.ToInt32(Console.ReadLine());
		int distanceInYards = distanceInFeet / 3;
		int distanceInMiles = distanceInYards / 1760;
		
		Console.WriteLine("Distance in feet is "+distanceInFeet+" so distance in yard is "+ distanceInYards+ " and distance in miles is " + distanceInMiles);
	
	}
}