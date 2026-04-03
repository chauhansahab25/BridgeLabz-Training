using System;


class PerimeterOfSquare
{
	static void Main()
	{
	
		Console.Write("Enter the side of square :");

	    int side = Convert.ToInt32(Console.ReadLine());
	    int perimeter = 4* side;
	    
		Console.WriteLine("The length of  the side is "+ side + " whose perimeter is "+perimeter);
	
	}
}