using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] sorted = (int[])arr.Clone();
        Array.Sort(sorted);
        int first = -1;
        int last = -1;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != sorted[i])
            {
                if (first == -1)
                    first = i;

                last = i;
            }
        }

        if (first == -1)
        {
            Console.WriteLine("already sorted");
            return;
        }
  
        int temp = arr[first];// Try one swap
        arr[first] = arr[last];
        arr[last] = temp;

        if (IsSorted(arr))
        {
            Console.WriteLine("swap " + (first + 1) + " " + (last + 1));
            return;
        }

        temp = arr[first];  // Undo swap
        arr[first] = arr[last];
        arr[last] = temp;

        
        int left = first;// Try reverse
        int right = last;

        while (left < right)
        {
            temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }

        if (IsSorted(arr))
            Console.WriteLine("reverse " + (first + 1) + " " + (last + 1));
        else
            Console.WriteLine("no");
    }
    static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
                return false;
        }

        return true;
    }
}