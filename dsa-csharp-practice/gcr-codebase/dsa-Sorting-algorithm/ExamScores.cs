using System;

namespace CG_Practice.dsa_csharp
{
    public class SelectionSort
    {
        public void SortExamScores(int[] scores)
        {
            int n = scores.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIdx])
                        minIdx = j;
                }
                int temp = scores[minIdx];
                scores[minIdx] = scores[i];
                scores[i] = temp;
            }
        }
    }
}