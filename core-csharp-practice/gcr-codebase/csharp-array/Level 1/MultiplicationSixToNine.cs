using System;

    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] multiplication = new int[4];
            int index = 0;

            for (int i = 6; i <= 9; i++)
            {
                multiplication[index] = number * i;
                index++;
            }

            Console.WriteLine("Multiplication Table:");

            index = 0;
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplication[index]);
                index++;
            }
        }
    }
}
