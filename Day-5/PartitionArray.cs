// using System;
// using System.Linq;

// class Program
// {
//     public static int partitionArray(int[] arr)
//     {
//         int pivot = arr[arr.Length - 1];

//         int i = 0;

//         for (int j = 0; j < arr.Length - 1; j++)
//         {
//             if (arr[j] < pivot)
//             {
//                 int temp = arr[i];
//                 arr[i] = arr[j];
//                 arr[j] = temp;

//                 i++;
//             }
//         }
//         int temp2 = arr[i];// Put pivot at correct posi
//         arr[i] = arr[arr.Length - 1];
//         arr[arr.Length - 1] = temp2;

//         return i;
//     }
//     static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//         int index = partitionArray(arr);

//         Console.WriteLine("Pivot Index: " + index);

//         Console.WriteLine("Array after partition:");

//         foreach (int x in arr)
//         {
//             Console.Write(x + " ");
//         }
//     }
// }