using System;

public class DoubleOperation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a : ");
        String input1 = Console.ReadLine();


        Console.WriteLine("Enter b : ");
        String input2 = Console.ReadLine();


        Console.WriteLine("Enter c : ");
        String input3 = Console.ReadLine();


        double a = double.Parse(input1);
        double b = double.Parse(input2);
        double c = double.Parse(input3);


        Console.WriteLine("The results of DoubleOperation are " + (a + b * c) + ", " + (a * b + c) + ", " + (c + a / b) + ", " + (a % b + c));
    }
}