using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    public class AdvancedQueueProblems
    {
        // Sliding window maximum using deque
        public int[] SlidingWindowMax(int[] nums, int k)
        {
            var dq = new LinkedList<int>();
            var res = new int[nums.Length - k + 1];
            int idx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // Remove out of window elements
                while (dq.Count > 0 && dq.First.Value <= i - k)
                    dq.RemoveFirst();

                // Remove smaller elements
                while (dq.Count > 0 && nums[dq.Last.Value] <= nums[i])
                    dq.RemoveLast();

                dq.AddLast(i);

                if (i >= k - 1)
                    res[idx++] = nums[dq.First.Value];
            }
            return res;
        }

        // Circular tour problem
        public int CircularTour(int[] petrol, int[] dist)
        {
            int n = petrol.Length;
            int start = 0, deficit = 0, tank = 0;

            for (int i = 0; i < n; i++)
            {
                tank += petrol[i] - dist[i];
                if (tank < 0)
                {
                    deficit += tank;
                    tank = 0;
                    start = i + 1;
                }
            }
            return tank + deficit >= 0 ? start : -1;
        }

        // Generate binary numbers from 1 to n
        public string[] GenerateBinary(int n)
        {
            var q = new Queue<string>();
            var res = new string[n];
            q.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string curr = q.Dequeue();
                res[i] = curr;
                q.Enqueue(curr + "0");
                q.Enqueue(curr + "1");
            }
            return res;
        }
    }
}