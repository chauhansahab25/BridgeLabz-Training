using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int comparisons = 0;
        for (int i = 0; i < n - 1; i++)
        {
            int max = i;

            for (int j = i + 1; j < n; j++)
            {
                comparisons++;

                if (arr[j] > arr[max])
                    max = j;
            }

            int temp = arr[i];
            arr[i] = arr[max];
            arr[max] = temp;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Comparisons: " + comparisons);
    }
}