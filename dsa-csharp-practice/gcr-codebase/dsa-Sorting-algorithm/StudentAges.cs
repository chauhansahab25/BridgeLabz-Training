using System;

namespace CG_Practice.dsa_csharp
{
    public class StudentAges
    {
        public void SortStudentAges(int[] ages)
        {
            int max = 18, min = 10;
            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[ages.Length];

            for (int i = 0; i < ages.Length; i++)
                count[ages[i] - min]++;

            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            for (int i = ages.Length - 1; i >= 0; i--)
            {
                output[count[ages[i] - min] - 1] = ages[i];
                count[ages[i] - min]--;
            }

            for (int i = 0; i < ages.Length; i++)
                ages[i] = output[i];
        }
    }
}