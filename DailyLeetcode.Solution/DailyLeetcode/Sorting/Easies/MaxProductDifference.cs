namespace DailyLeetcode.Sorting.Easies;
public sealed class MaxProductDifference
{
    private int MaxProductDifferences(int[] nums)
    {
        Array.Sort(nums);

        int maximalDiffirent =
            nums[nums.Length - 1] * nums[nums.Length - 2] - nums[0] * nums[1];

        return maximalDiffirent;
    }
}
