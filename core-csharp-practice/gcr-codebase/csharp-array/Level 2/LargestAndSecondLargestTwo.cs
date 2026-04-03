using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{
    public class LargestAndSecondLargestTwo
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int maxDigit = 10;
            int[] arr = new int[maxDigit];
            int index = 0;

            while (number != 0)
            {
                if (index == maxDigit)
                {
                    maxDigit = maxDigit + 10;

                    int[] temp = new int[maxDigit];


                    for (int i = 0; i < arr.Length; i++)
                    {
                        temp[i] = arr[i];
                    }

                    arr = temp; // assign new array
                }

                arr[index] = number % 10;

                number = number / 10;

                index++;

            }


            int largest = arr[0];
            int secondLargest = arr[1];

            for (int i = 1; i < maxDigit; i++)
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
