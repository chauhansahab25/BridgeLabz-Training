using System;
using System.Linq;

class Program
{
    public static string isSortedAfterOnePass(int[] arr)
    {
        partitionArray(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return "NO";
            }
        }
        return "YES";
    }

    public static int partitionArray(int[] arr)
    {
        int pivot = arr[arr.Length - 1];
        int i = 0;
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] < pivot)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
            }
        }
        int temp2 = arr[i];
        arr[i] = arr[arr.Length - 1];
        arr[arr.Length - 1] = temp2;
        return i;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string result = isSortedAfterOnePass(arr);

        Console.WriteLine(result);
    }
}