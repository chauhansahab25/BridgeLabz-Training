using System;

namespace CG_Practice.dsa_csharp
{
    public class JobSalaries
    {
        public void SortJobSalaries(int[] salaries)
        {
            int n = salaries.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;
                Heapify(salaries, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, n, largest);
            }
        }
    }
}