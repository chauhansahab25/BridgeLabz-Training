using System;

class Areaofcircle
{
    static void Main()
    {
        Console.Write("Enter radius of circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of circle: " + area);
    }
}
