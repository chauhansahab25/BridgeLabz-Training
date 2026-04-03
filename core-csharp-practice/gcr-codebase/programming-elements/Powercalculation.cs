using System;

class Powercalculation
{
    static void Main()
    {
        Console.Write("Enter base: ");
        int baseNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());
        
        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Result: " + result);
    }
}
