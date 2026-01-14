using System;
using System.Diagnostics;

namespace CG_Practice.dsacsharp
{
    class SortingLargeData
    {
        static Random rand = new Random();
        
        static void Main(string[] args)
        {
            int[] sizes = { 1000, 10000, 100000 };
            
            Console.WriteLine("Dataset Size\tBubble Sort\tMerge Sort\tQuick Sort");
            Console.WriteLine("---------------------------------------------------------------");
            
            foreach (int size in sizes)
            {
                int[] original = new int[size];
                for (int i = 0; i < size; i++) 
                    original[i] = rand.Next(size);
                
                int[] data = (int[])original.Clone();
                Stopwatch sw = Stopwatch.StartNew();
                BubbleSort(data);
                sw.Stop();
                double bubbleTime = sw.Elapsed.TotalMilliseconds;
                
                data = (int[])original.Clone();
                sw.Restart();
                MergeSort(data, 0, data.Length - 1);
                sw.Stop();
                double mergeTime = sw.Elapsed.TotalMilliseconds;
                
                data = (int[])original.Clone();
                sw.Restart();
                QuickSort(data, 0, data.Length - 1);
                sw.Stop();
                double quickTime = sw.Elapsed.TotalMilliseconds;
                
                Console.WriteLine($"{size,12}\t{bubbleTime:F2}ms\t\t{mergeTime:F2}ms\t\t{quickTime:F2}ms");
            }
        }
        
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            
            while (i <= mid) 
                temp[k++] = arr[i++];
            while (j <= right) 
                temp[k++] = arr[j++];
            
            for (i = 0; i < temp.Length; i++)
                arr[left + i] = temp[i];
        }
        
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            
            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;
            
            return i + 1;
        }
    }
}
