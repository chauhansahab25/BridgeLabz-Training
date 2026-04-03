using System;

namespace CG_Practice.dsa_csharp
{
    public class ZeroSumSubarrays
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

            public void Put(int key, int val)
            {
                int idx = Hash(key);
                if (buckets[idx] == null)
                    buckets[idx] = new int[] { key, val };
                else
                {
                    for (int i = 0; i < buckets[idx].Length; i += 2)
                    {
                        if (buckets[idx][i] == key)
                        {
                            buckets[idx][i + 1] = val;
                            return;
                        }
                    }
                    int[] newBucket = new int[buckets[idx].Length + 2];
                    Array.Copy(buckets[idx], newBucket, buckets[idx].Length);
                    newBucket[buckets[idx].Length] = key;
                    newBucket[buckets[idx].Length + 1] = val;
                    buckets[idx] = newBucket;
                }
            }

            public bool ContainsKey(int key)
            {
                int idx = Hash(key);
                if (buckets[idx] == null) return false;
                for (int i = 0; i < buckets[idx].Length; i += 2)
                    if (buckets[idx][i] == key) return true;
                return false;
            }

            public int Get(int key)
            {
                int idx = Hash(key);
                if (buckets[idx] != null)
                    for (int i = 0; i < buckets[idx].Length; i += 2)
                        if (buckets[idx][i] == key) return buckets[idx][i + 1];
                return -1;
            }
        }

        public int[][] FindZeroSumSubarrays(int[] arr)
        {
            var map = new CustomHashMap();
            var res = new int[arr.Length * arr.Length][];
            int count = 0, sum = 0;

            map.Put(0, -1);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (map.ContainsKey(sum))
                {
                    int start = map.Get(sum);
                    res[count++] = new int[] { start + 1, i };
                }
                map.Put(sum, i);
            }

            int[][] result = new int[count][];
            Array.Copy(res, result, count);
            return result;
        }
    }
}