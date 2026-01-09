using System;

namespace CG_Practice.dsa_csharp
{
    public class PairSum
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
        }

        public bool HasPairWithSum(int[] arr, int target)
        {
            var map = new CustomHashMap();
            
            foreach (int num in arr)
            {
                if (map.Contains(target - num))
                    return true;
                map.Add(num);
            }
            return false;
        }
    }
}