// using System;
// using System.Linq;

// class Program
// {
//     public static int quicksortComparisons(int[] arr)
//     {
//         int count = 0;
//         quickSort(arr, 0, arr.Length - 1, ref count);
//         return count;
//     }

//     static void quickSort(int[] arr, int low, int high, ref int count)
//     {
//         if (low < high)
//         {
//             int pivotIndex = partition(arr, low, high, ref count);
//             quickSort(arr, low, pivotIndex - 1, ref count);
//             quickSort(arr, pivotIndex + 1, high, ref count);
//         }
//     }

//     static int partition(int[] arr, int low, int high, ref int count)
//     {
//         int pivot = arr[high];
//         int i = low;
//         for (int j = low; j < high; j++)
//         {
//             count++;

//             if (arr[j] < pivot)
//             {
//                 int temp = arr[i];
//                 arr[i] = arr[j];
//                 arr[j] = temp;

//                 i++;
//             }
//         }
//         int temp2 = arr[i];
//         arr[i] = arr[high];
//         arr[high] = temp2;
//         return i;
//     }

//     static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//         int result = quicksortComparisons(arr);
//         Console.WriteLine(result);
//     }
// }