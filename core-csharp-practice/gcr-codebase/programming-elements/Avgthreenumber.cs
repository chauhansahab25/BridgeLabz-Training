using System;

class Avgthreenumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        int average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average: " + average);
    }
}
