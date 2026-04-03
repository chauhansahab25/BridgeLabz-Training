using System;

class SumOfNNaturalNumber
{
    static void Main(String [] args)
    {
        Console.Write("Enter a number ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int tot = 0;
            int i = 1;

            while (i <= n)
            {
                tot = tot+ i;
                i++;
            }

            int sumByFormula = n * (n + 1) / 2;

            Console.WriteLine("Sum using while loop: " + tot);
            Console.WriteLine("Sum using formula: " + sumByFormula);

            if (tot == sumByFormula)
            {
                Console.WriteLine("Both results are correct and equal.");
            }
            else
            {
                Console.WriteLine("Results are not equal.");
            }
        }
        else
        {
            Console.WriteLine("The number " + n + " is not a natural number.");
        }
    }
}