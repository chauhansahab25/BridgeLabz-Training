using System;
using System.Collections.Generic;

namespace CG_Practice.dsa_csharp
{
    public class HashMapProblems
    {
        // Find all subarrays with zero sum
        public List<int[]> ZeroSumSubarrays(int[] arr)
        {
            var map = new Dictionary<int, List<int>>();
            var res = new List<int[]>();
            int sum = 0;

            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (map.ContainsKey(sum))
                {
                    foreach (int start in map[sum])
                        res.Add(new int[] { start + 1, i });
                    map[sum].Add(i);
                }
                else
                    map[sum] = new List<int> { i };
            }
            return res;
        }

        // Check for pair with given sum
        public bool HasPairSum(int[] arr, int target)
        {
            var set = new HashSet<int>();
            foreach (int num in arr)
            {
                if (set.Contains(target - num))
                    return true;
                set.Add(num);
            }
            return false;
        }

        // Longest consecutive sequence
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>(nums);
            int maxLen = 0;

            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int curr = num, len = 1;
                    while (set.Contains(curr + 1))
                    {
                        curr++;
                        len++;
                    }
                    maxLen = Math.Max(maxLen, len);
                }
            }
            return maxLen;
        }

        // Two sum problem
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int comp = target - nums[i];
                if (map.ContainsKey(comp))
                    return new int[] { map[comp], i };
                map[nums[i]] = i;
            }
            return new int[0];
        }
    }
}