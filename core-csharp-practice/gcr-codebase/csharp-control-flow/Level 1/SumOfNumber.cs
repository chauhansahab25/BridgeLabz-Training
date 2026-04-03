using System;

class SumOfNumber
{
    static void Main(String []args)
    {
        double total = 0.0;
        double value;

        Console.Write("Enter a number press 0 to stop the the program ");
        value = Convert.ToDouble(Console.ReadLine());

        while (value != 0)
        {
            total = total + value;

            Console.Write("Enter a number (0 to stop): ");
            value = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("The total is " + total);
    }
}