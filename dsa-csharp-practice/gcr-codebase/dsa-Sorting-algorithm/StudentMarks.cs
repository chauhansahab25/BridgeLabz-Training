using System;

namespace CG_Practice.dsa_csharp
{
    public class BubbleSort
    {
        public void SortStudentMarks(int[] marks)
        {
            int n = marks.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }
        }
    }
}