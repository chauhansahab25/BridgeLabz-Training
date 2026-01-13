using System;

namespace CG_Practice.dsacsharp.binarysearch
{
    class RotationPoint
    {
        static void Main()
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            
            Console.WriteLine("Rotated sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            int rotationIndex = FindRotationPoint(arr);
            
            Console.WriteLine("Rotation point index: " + rotationIndex);
            Console.WriteLine("Smallest element: " + arr[rotationIndex]);
            
            Console.ReadKey();
        }
        
        static int FindRotationPoint(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] > arr[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            
            return left;
        }
    }
}