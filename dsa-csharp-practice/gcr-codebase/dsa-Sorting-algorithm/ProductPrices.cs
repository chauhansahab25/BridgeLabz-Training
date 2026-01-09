using System;

namespace CG_Practice.dsa_csharp
{
    public class QuickSort
    {
        public void SortProductPrices(int[] prices)
        {
            QuickSortHelper(prices, 0, prices.Length - 1);
        }

        private void QuickSortHelper(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSortHelper(arr, low, pi - 1);
                QuickSortHelper(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
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

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;
            return i + 1;
        }
    }
}