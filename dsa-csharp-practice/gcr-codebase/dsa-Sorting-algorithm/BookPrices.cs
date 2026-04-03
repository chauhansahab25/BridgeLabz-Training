using System;

namespace CG_Practice.dsa_csharp
{
    public class MergeSort
    {
        public void SortBookPrices(int[] prices)
        {
            MergeSortHelper(prices, 0, prices.Length - 1);
        }

        private void MergeSortHelper(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortHelper(arr, left, mid);
                MergeSortHelper(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            Array.Copy(arr, left, leftArr, 0, n1);
            Array.Copy(arr, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                    arr[k++] = leftArr[i++];
                else
                    arr[k++] = rightArr[j++];
            }

            while (i < n1) arr[k++] = leftArr[i++];
            while (j < n2) arr[k++] = rightArr[j++];
        }
    }
}