using System;

namespace CG_Practice.dsa_csharp
{
    public class InsertionSort
    {
        public void SortEmployeeIds(int[] ids)
        {
            int n = ids.Length;
            for (int i = 1; i < n; i++)
            {
                int key = ids[i];
                int j = i - 1;
                while (j >= 0 && ids[j] > key)
                {
                    ids[j + 1] = ids[j];
                    j--;
                }
                ids[j + 1] = key;
            }
        }
    }
}