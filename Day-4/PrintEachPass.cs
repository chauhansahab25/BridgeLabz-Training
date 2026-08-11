using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 1; i < n; i++)
        {
            int value = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > value)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = value;

            PrintArray(arr);
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}