using System;

    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] multiplication = new int[10];

            for (int i = 0; i < multiplication.Length; i++)
            {
                multiplication[i] = number * (i + 1);
            }

            Console.WriteLine("multiplication table");

            for (int i = 0; i < multiplication.Length; i++) { 
                Console.WriteLine(number +" * "+ (i+1) +" = "+ multiplication[i]);
            }
        }
    }
}
