using System;

class CounterForLoop
{
    static void Main()
    {
        Console.Write("Enter countdown number");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = number; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}