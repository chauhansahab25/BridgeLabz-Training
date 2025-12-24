using System;

class SumOfNNaturalNumberUsingForLoop
{
    static void Main(String [] args)
    {
        Console.Write("Enter a number ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int tot = 0;
           

            for(int i=1;i <= n;i++)
            {
                tot = tot+ i;
                
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