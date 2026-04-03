using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class SmallestAndLargest
    {
        static void Main(string[] args)
        {

            //taking inputs from user 
            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int[] ans = FindSmallestAndLargest(n1, n2, n3);

            Console.WriteLine("Smallest number :" + ans[0]);
            Console.WriteLine("Largest number :" + ans[1]);
        }

        static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = number1;
            int largest = number1;

            if (number2 < smallest)
                smallest = number2;

            if (number3 < smallest)
                smallest = number3;

            if (number2 > largest)
                largest = number2;

            if (number3 > largest)
                largest = number3;

            return new int[] { smallest, largest };

        }
    }
}
