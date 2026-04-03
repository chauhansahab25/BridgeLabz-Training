using System;
using System.Collections.Generic;

public class ThreeSum
{
    public IList<IList<int>> ThreeSum(int[] num)
    {
        Array.Sort(num);
        IList<IList<int>> result = new List<IList<int>>();

        int n = num.Length;

        for (int i = 0; i < n - 2; i++)
        {
            
            if (i > 0 && num[i] == num[i - 1])
                continue;

            
            if (nums[i] > 0)
                break;

            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int sum = num[i] + num[left] + num[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { num[i], num[left], num[right] });

                   
                    while (left < right && num[left] == num[left + 1])
                        left++;

                    
                    while (left < right && num[right] == num[right - 1])
                        right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}
