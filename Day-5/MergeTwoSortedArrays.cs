// using System;
// using System.Linq;

// class Program
// {
//     public static int[] mergeSortedArrays(int[] a, int[] b)
//     {
//         int[] result = new int[a.Length + b.Length];
//         int i = 0;
//         int j = 0;
//         int k = 0;
//         while (i < a.Length && j < b.Length)
//         {
//             if (a[i] <= b[j])
//             {
//                 result[k] = a[i];
//                 i++;
//             }
//             else
//             {
//                 result[k] = b[j];
//                 j++;
//             }
//             k++;
//         }
//         while (i < a.Length)
//         {
//             result[k] = a[i];
//             i++;
//             k++;
//         }
//         while (j < b.Length)
//         {
//             result[k] = b[j];
//             j++;
//             k++;
//         }
//         return result;
//     }

//     static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
//         int m = int.Parse(Console.ReadLine());
//         int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
//         int[] result = mergeSortedArrays(a, b);
//         foreach (int x in result)
//         {
//             Console.Write(x + " ");
//         }
//     }
// }