using System;
using System.Linq;

class Program
{
    public static int[] mergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];
        for (int i = 0; i < mid; i++)
        {
            left[i] = arr[i];
        }
        for (int i = mid; i < arr.Length; i++)
        {
            right[i - mid] = arr[i];
        }
        left = mergeSort(left);
        right = mergeSort(right);

        return merge(left, right);
    }
    static int[] merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k] = left[i];
                i++;
            }
            else
            {
                result[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < left.Length)
        {
            result[k] = left[i];
            i++;
            k++;
        }
        while (j < right.Length)
        {
            result[k] = right[j];
            j++;
            k++;
        }
        return result;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] result = mergeSort(arr);
        foreach (int x in result)
        {
            Console.Write(x + " ");
        }
    }
}