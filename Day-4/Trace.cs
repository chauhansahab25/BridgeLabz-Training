using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min])
                    min = j;
            }

            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;

            PrintArray(arr);
        }
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}