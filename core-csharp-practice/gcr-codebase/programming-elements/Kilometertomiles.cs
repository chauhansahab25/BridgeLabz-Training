using System;

class Kilometertomiles
{
    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        int kilometers = Convert.ToInt32(Console.ReadLine());
        
        double miles = kilometers * 0.621371;
        Console.WriteLine("Distance in miles: " + miles);
    }
}
