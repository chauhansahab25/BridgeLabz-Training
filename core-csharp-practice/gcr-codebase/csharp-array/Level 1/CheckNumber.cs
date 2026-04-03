using System;

    public class CheckNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter Number " + (i + 1) + " :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0;i< numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    Console.WriteLine("Negative Number :");
                }
                else if (numbers[i] == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine("Even Number");
                    }
                    else
                    {
                        Console.WriteLine("Odd Number");
                    }
                }
                
            }
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Console.WriteLine("The first element and last number are equal");
            }
            else if (numbers[0] < numbers[numbers.Length - 1])
            {
                Console.WriteLine("The first element is less than last element");
            }
            else
            {
                Console.WriteLine("The first element is greater than last number");
            }

        }
    }
}
