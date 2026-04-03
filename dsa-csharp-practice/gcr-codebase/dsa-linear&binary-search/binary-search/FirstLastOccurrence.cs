using System;

namespace CG_Practice.dsacsharp.binarysearch
{
    class FirstLastOccurrence
    {
        static void Main()
        {
            int[] arr = { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Target: " + target);
            
            int first = FindFirstOccurrence(arr, target);
            int last = FindLastOccurrence(arr, target);
            
            if (first != -1)
            {
                Console.WriteLine("First occurrence at index: " + first);
                Console.WriteLine("Last occurrence at index: " + last);
            }
            else
            {
                Console.WriteLine("Target not found");
            }
            
            Console.ReadKey();
        }
        
        static int FindFirstOccurrence(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int result = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                {
                    result = mid;
                    right = mid - 1; // continue searching left
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            return result;
        }
        
        static int FindLastOccurrence(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int result = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                {
                    result = mid;
                    left = mid + 1; // continue searching right
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            return result;
        }
    }
}