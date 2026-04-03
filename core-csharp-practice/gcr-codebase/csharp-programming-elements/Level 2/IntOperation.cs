using System;

public class IntOperation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a : ");
        String input1 = Console.ReadLine();


        Console.WriteLine("Enter b : ");
        String input2 = Console.ReadLine();


        Console.WriteLine("Enter c : ");
        String input3 = Console.ReadLine();


        int a = int.Parse(input1);
        int b = int.Parse(input2);
        int c = int.Parse(input3);

        Console.WriteLine("The results of IntOperation are " + (a + b * c) + ", " + (a * b + c) + ", " + (c + a / b) + ", " + (a % b + c));
    }
}