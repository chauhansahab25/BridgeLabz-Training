using System;

namespace CG_Practice.dsacsharp.binarysearch
{
    class MissingPositiveAndBinarySearch
    {
        static void Main()
        {
            int[] arr = { 3, 4, -1, 1, 7, 2, 9 };
            int target = 4;
            
            Console.WriteLine("Original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            // find first missing positive using linear search
            int missingPositive = FindFirstMissingPositive(arr);
            Console.WriteLine("First missing positive: " + missingPositive);
            
            // sort array for binary search
            Array.Sort(arr);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            // binary search for target
            int targetIndex = BinarySearch(arr, target);
            if (targetIndex != -1)
            {
                Console.WriteLine("Target " + target + " found at index: " + targetIndex);
            }
            else
            {
                Console.WriteLine("Target " + target + " not found");
            }
            
            Console.ReadKey();
        }
        
        static int FindFirstMissingPositive(int[] nums)
        {
            int n = nums.Length;
            
            // mark numbers as visited by making them negative
            for (int i = 0; i < n; i++)
            {
                int num = Math.Abs(nums[i]);
                if (num >= 1 && num <= n)
                {
                    if (nums[num - 1] > 0)
                    {
                        nums[num - 1] = -nums[num - 1];
                    }
                }
            }
            
            // find first positive number
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1;
                }
            }
            
            return n + 1;
        }
        
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                {
                    return mid;
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
            
            return -1;
        }
    }
}