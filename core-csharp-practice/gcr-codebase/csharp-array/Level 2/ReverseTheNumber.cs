using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{
    public class ReverseTheNumber
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter  number :");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Reverse number of 0 is 0");
            }

            int temp = n;
            int count = 0;

            while (temp != 0)
            {
                count++;
                temp = temp / 10;

            }
            int[] num = new int[count];
            int[] reverseNum = new int[count];

            temp = n;

            for (int i = 0; i < count; i++)
            {
                reverseNum[i] = temp % 10;
                temp /= 10;

            }


            Console.WriteLine("Reverse number is :");
            for (int i = 0; i < count; i++)
            {
                Console.Write(reverseNum[i]);
            }


        }
    }
}
