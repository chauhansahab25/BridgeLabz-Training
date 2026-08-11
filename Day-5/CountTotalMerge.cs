using System;
using System.Linq;

class Program
{
    static int mergeCount = 0;
    public static int countMergeOperations(int[] arr)
    {
        mergeCount = 0;
        mergeSort(arr, 0, arr.Length - 1);
        return mergeCount;
    }
    static void mergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
        {
            return;
        }
        int mid = (left + right) / 2;
        mergeSort(arr, left, mid);
        mergeSort(arr, mid + 1, right);
        merge(arr, left, mid, right);
        mergeCount++;
    }
    static void merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left;
        int j = mid + 1;
        int k = 0;
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
        for (int x = 0; x < temp.Length; x++)
        {
            arr[left + x] = temp[x];
        }
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int result = countMergeOperations(arr);
        Console.WriteLine(result);
    }
}