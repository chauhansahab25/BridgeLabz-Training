using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] temp = new int[n];
        long result = MergeSort(arr, temp, 0, n - 1);
        Console.WriteLine(result);
    }
    static long MergeSort(int[] arr, int[] temp, int left, int right)
    {
        if (left >= right)
            return 0;

        int mid = (left + right) / 2;

        long count = 0;

        count += MergeSort(arr, temp, left, mid);
        count += MergeSort(arr, temp, mid + 1, right);
        count += Merge(arr, temp, left, mid, right);
        return count;
    }
    static long Merge(
        int[] arr,
        int[] temp,
        int left,
        int mid,
        int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        long count = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
            {
                temp[k] = arr[i];
                i++;
            }
            else
            {
                temp[k] = arr[j];
                j++;

                count += mid - i + 1;
            }

            k++;
        }

        while (i <= mid)
        {
            temp[k] = arr[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            temp[k] = arr[j];
            j++;
            k++;
        }

        for (i = left; i <= right; i++)
        {
            arr[i] = temp[i];
        }
        return count;
    }
}