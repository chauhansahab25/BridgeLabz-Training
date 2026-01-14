using System;
using System.Diagnostics;

namespace CG_Practice.dsacsharp
{
    class SearchTarget
    {
        static void Main(string[] args)
        {
            int[] sizes = { 1000, 10000, 1000000 };
            
            Console.WriteLine("Dataset Size\tLinear Search\tBinary Search");
            Console.WriteLine("---------------------------------------------------");
            
            foreach (int size in sizes)
            {
                int[] data = new int[size];
                for (int i = 0; i < size; i++) 
                    data[i] = i;
                
                int target = size - 1;
                
                Stopwatch sw = Stopwatch.StartNew();
                LinearSearch(data, target);
                sw.Stop();
                double linearTime = sw.Elapsed.TotalMilliseconds;
                
                sw.Restart();
                Array.Sort(data);
                BinarySearch(data, target);
                sw.Stop();
                double binaryTime = sw.Elapsed.TotalMilliseconds;
                
                Console.WriteLine($"{size,12}\t{linearTime:F4}ms\t{binaryTime:F4}ms");
            }
        }
        
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == target) 
                    return i;
            return -1;
        }
        
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target) 
                    return mid;
                    
                if (arr[mid] < target) 
                    left = mid + 1;
                else 
                    right = mid - 1;
            }
            
            return -1;
        }
    }
}
