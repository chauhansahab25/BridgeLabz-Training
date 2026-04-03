using System;

class Volumeofcylinder
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of cylinder: " + volume);
    }
}
