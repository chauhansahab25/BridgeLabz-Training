using System;

namespace CG_Practice.dsacsharp.binarysearch
{
    class PeakElement
    {
        static void Main()
        {
            int[] arr = { 1, 3, 20, 4, 1, 0 };
            
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            int peakIndex = FindPeakElement(arr);
            
            Console.WriteLine("Peak element index: " + peakIndex);
            Console.WriteLine("Peak element value: " + arr[peakIndex]);
            
            Console.ReadKey();
        }
        
        static int FindPeakElement(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] < arr[mid + 1])
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