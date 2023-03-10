﻿namespace DailyLeetcode.Arrays.Easies;
internal class ContainsNearbyDuplicate
{
    public static bool ContainsNearbyDuplicates(int[] nums, int k)
    {
        Dictionary<int, int> record = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (record.Keys.Contains(nums[i]))
            {
                if (i - record[nums[i]] <= k)
                    return true;

                record[nums[i]] = i;
            }
            else
                record.Add(nums[i], i);
        }

        return false;
    }
}