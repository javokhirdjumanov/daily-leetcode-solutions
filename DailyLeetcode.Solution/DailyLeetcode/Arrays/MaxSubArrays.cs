namespace DailyLeetcode.Arrays;

public class MaxSubArrays
{
    public static int MaxSubArray(int[] nums)
    {
        // return OneSolution(nums);

        return TwoSolution(nums);
    }
    private static int OneSolution(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];

        int localMax = 0, globalMax = int.MinValue;

        for (int iterator = 0; iterator < nums.Length; iterator++)
        {
            localMax = Math.Max(nums[iterator], nums[iterator] + localMax);
            globalMax = Math.Max(localMax, globalMax);
        }

        return globalMax;
    }
    private static int TwoSolution(int[] nums)
    {
        int left = 0, right = 0, max = int.MinValue, SumLeft = 0;

        while (right < nums.Length && left < nums.Length)
        {
            SumLeft += nums[right++];
            max = Math.Max(max, SumLeft);

            if (right == nums.Length)
            {
                left++;
                right = left;
                SumLeft = 0;
            }
        }

        return max;
    }
}
