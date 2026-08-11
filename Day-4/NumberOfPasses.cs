using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int passes = 0;
        for (int i = 0; i < n; i++)
        {
            int swaps = 0;

            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swaps++;
                }
            }
            passes++;
            if (swaps == 0)
                break;
        }

        Console.WriteLine(passes);
    }
}