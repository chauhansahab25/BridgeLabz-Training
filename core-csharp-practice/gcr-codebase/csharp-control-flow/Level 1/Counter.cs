using System;

class Counter
{
    static void Main()
    {
        Console.Write("Enter countdown number  ");
        int counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter = counter - 1;
        }
    }
}