using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class FriendsComparison
    {
        // find the youngest friend
        public static int FindYoungest(int[] ages)
        {
            int youngestIndex = 0;

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[youngestIndex])
                {
                    youngestIndex = i;
                }
            }
            return youngestIndex;
        }

        // find the tallest friend
        public static int FindTallest(double[] heights)
        {
            int tallestIndex = 0;

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[tallestIndex])
                {
                    tallestIndex = i;
                }
            }
            return tallestIndex;
        }

        static void Main(string[] args)
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] heights = new double[3];

           
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter age of " + names[i] + ": ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter height of " + names[i] + " (in cm): ");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }

            int youngestIndex = FindYoungest(ages);
            int tallestIndex = FindTallest(heights);

            Console.WriteLine();
            Console.WriteLine("Youngest friend is: " + names[youngestIndex]);
            Console.WriteLine("Tallest friend is: " + names[tallestIndex]);
        }
    }
}
