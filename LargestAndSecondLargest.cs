using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{
    public class LargestAndSecondLargest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the digits");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = arr[0];
            int secondLargest = arr[1];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }


            //largest
            Console.WriteLine("The largest is " + largest);

            //secondLargest
            Console.WriteLine("The second largest is " + secondLargest);







        }
    }
}

