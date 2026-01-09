using System;
using System.Collections.Generic;

namespace CG_Practice.dsacsharp
{
    public class SlidingWindowMax
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var dq = new LinkedList<int>();
            var res = new int[nums.Length - k + 1];
            int idx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                while (dq.Count > 0 && dq.First.Value <= i - k)
                    dq.RemoveFirst();

                while (dq.Count > 0 && nums[dq.Last.Value] <= nums[i])
                    dq.RemoveLast();

                dq.AddLast(i);

                if (i >= k - 1)
                    res[idx++] = nums[dq.First.Value];
            }
            return res;
        }
    }
}