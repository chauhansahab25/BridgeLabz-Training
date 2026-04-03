using System;

class Perimeterofrectangle
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        int perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of rectangle: " + perimeter);
    }
}
