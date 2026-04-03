using System;
using System.Collections.Generic;
public class ContainsDuplicate {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;   // Duplicate found
            }
            set.Add(num);
        }

        return false;  // No duplicates
    }
}