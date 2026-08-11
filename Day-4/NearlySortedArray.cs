using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int comparisons = 0;
        for (int i = 1; i < n; i++)
        {
            int value = arr[i];
            int j = i - 1;

            while (j >= 0)
            {
                comparisons++;

                if (arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                else
                {
                    break;
                }
            }

            arr[j + 1] = value;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Comparisons: " + comparisons);
    }
}