using System;

public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        if (nums1.Length > nums2.Length) 
        {
            int[] temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }
        
        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;
        
        while (left <= right) 
        {
            int cut1 = (left + right) / 2;  
            int cut2 = (m + n + 1) / 2 - cut1; 
            
            int left1 = (cut1 == 0) ? int.MinValue : nums1[cut1 - 1];
            int left2 = (cut2 == 0) ? int.MinValue : nums2[cut2 - 1];
            
            int right1 = (cut1 == m) ? int.MaxValue : nums1[cut1];
            int right2 = (cut2 == n) ? int.MaxValue : nums2[cut2];
            
            if (left1 <= right2 && left2 <= right1) 
            {
                if ((m + n) % 2 == 1) 
                {
                    return Math.Max(left1, left2);
                }
                else 
                {
                    return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;
                }
            }
            else if (left1 > right2) 
            {
                right = cut1 - 1;  
            }
            else 
            {
                left = cut1 + 1;   
            }
        }
        
        return 1.0;  
    }
}