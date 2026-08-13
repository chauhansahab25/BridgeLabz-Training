// // 4. Rotate Array
// // Concept: Array Rotation
// // Rotate an array to the right by k steps.
// // Example
// // Input:
// // nums = [1,2,3,4,5,6,7]
// // k = 3

// // Output:
// // [5,6,7,1,2,3,4]

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter Array Size: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("Enter Elements: ");
//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine("Enter value of k: ");
//         int k = Convert.ToInt32(Console.ReadLine());
//         k = k % n;
//         int[] result = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             int index = (i + k) % n;
//             result[index] = arr[i];
//         }
//         Console.WriteLine("New Array: ");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(result[i]+ " ");
//         }
//     }
// }
