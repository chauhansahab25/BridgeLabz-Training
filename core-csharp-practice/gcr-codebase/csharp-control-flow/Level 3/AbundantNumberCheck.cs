using System;

public class AbundantNumberCheck
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum > number)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}