using System;

namespace CG_Practice.dsa_csharp
{
    public class LongestConsecutive
    {
        private class CustomHashMap
        {
            private int[][] buckets;
            private int cap;

            public CustomHashMap(int size = 16)
            {
                cap = size;
                buckets = new int[cap][];
            }

            private int Hash(int key) => Math.Abs(key) % cap;

            public void Add(int key)
            {
                int idx = Hash(key);
                if (buckets[idx] == null)
                    buckets[idx] = new int[] { key };
                else
                {
                    for (int i = 0; i < buckets[idx].Length; i++)
                        if (buckets[idx][i] == key) return;
                    
                    int[] newBucket = new int[buckets[idx].Length + 1];
                    Array.Copy(buckets[idx], newBucket, buckets[idx].Length);
                    newBucket[buckets[idx].Length] = key;
                    buckets[idx] = newBucket;
                }
            }

            public bool Contains(int key)
            {
                int idx = Hash(key);
                if (buckets[idx] == null) return false;
                for (int i = 0; i < buckets[idx].Length; i++)
                    if (buckets[idx][i] == key) return true;
                return false;
            }

            public int[] GetAllKeys()
            {
                int[] keys = new int[1000];
                int count = 0;
                for (int i = 0; i < cap; i++)
                {
                    if (buckets[i] != null)
                        for (int j = 0; j < buckets[i].Length; j++)
                            keys[count++] = buckets[i][j];
                }
                int[] result = new int[count];
                Array.Copy(keys, result, count);
                return result;
            }
        }

        public int LongestConsecutiveSequence(int[] nums)
        {
            var map = new CustomHashMap();
            foreach (int num in nums)
                map.Add(num);

            int maxLen = 0;
            int[] allKeys = map.GetAllKeys();

            foreach (int num in allKeys)
            {
                if (!map.Contains(num - 1))
                {
                    int curr = num, len = 1;
                    while (map.Contains(curr + 1))
                    {
                        curr++;
                        len++;
                    }
                    maxLen = Math.Max(maxLen, len);
                }
            }
            return maxLen;
        }
    }
}