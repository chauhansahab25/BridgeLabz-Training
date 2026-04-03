using System;
class AreaOfTriangle{
	static void Main()
	{
	
		Console.Write("Enter the base of triangle");
	    int base = Convert.ToInt32(Console.ReadLine());
	
		Console.Write("Enter the height of triangle");
	    int height = Convert.ToInt32(Console.ReadLine());
	    int area = (1/2)*base*height;
	
		Console.WriteLine("Area of triangle is" + area);
	
	
}
}