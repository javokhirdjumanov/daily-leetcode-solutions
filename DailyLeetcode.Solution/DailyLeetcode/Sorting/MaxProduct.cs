namespace DailyLeetcode.Sorting;
public sealed class MaxProduct
{
    private int MaxProducts(int[] nums)
    {
        Array.Sort(nums);

        int result =
            (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);

        return result;
    }
}
