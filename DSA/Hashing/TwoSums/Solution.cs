
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> intMap = new(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (intMap.TryGetValue(diff, out int index))
                return new int[] { index, i };

            intMap.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
