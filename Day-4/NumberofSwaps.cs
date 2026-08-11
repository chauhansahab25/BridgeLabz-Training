using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int swaps = 0;
        for (int i = 0; i < n; i++)
        {
            bool changed = false;

            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swaps++;
                    changed = true;
                }
            }

            if (!changed)
                break;
        }

        if (swaps == 0)
            Console.WriteLine("Array is already sorted");
        else if (swaps == n)
            Console.WriteLine("Too chaotic");
        else
            Console.WriteLine("Array is sorted in " + swaps + " swaps.");

        Console.WriteLine("First Element: " + arr[0]);
        Console.WriteLine("Last Element: " + arr[n - 1]);
    }
}