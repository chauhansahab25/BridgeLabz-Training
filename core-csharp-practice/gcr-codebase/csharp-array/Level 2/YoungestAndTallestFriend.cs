using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{
    public class YoungestAndTallestFriend
    {
        public static void Main(string[] args)
        {
            //Three Friends
            string[] Friends = { "Ram", "Lakshman", "Bharat" };
            for (int i = 0; i < Friends.Length; i++)
            {
                Console.WriteLine(Friends[i]);
            }


            int[] age = new int[3];//age array


            double[] height = new double[3];//height array


            for (int i = 0; i < Friends.Length; i++)
            {

                Console.Write($"Enter detail of {Friends[i]}");//taking input

                Console.Write("\nEnter age");
                age[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter height");
                height[i] = Convert.ToDouble(Console.ReadLine());


            }


            int YoungestIndex = 0;
            int TallestIndex = 0;

            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[YoungestIndex])
                    YoungestIndex = i;

                if (height[i] > height[TallestIndex])
                    TallestIndex = i;
            }
            Console.WriteLine("Youngest Friend  is: " + Friends[YoungestIndex]);
            Console.WriteLine("Tallest Friend  is: " + Friends[TallestIndex]);



        }
    }
}
