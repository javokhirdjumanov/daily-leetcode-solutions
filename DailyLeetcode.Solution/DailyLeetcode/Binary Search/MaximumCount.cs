namespace DailyLeetcode.Binary_Search;
public sealed class MaximumCount
{
    public static int MaximumCounts(int[] nums)
    {
        int pos = 0, neg = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
                neg++;
            else if (nums[i] > 0)
                pos++;
        }
        int max = Math.Max(pos, neg);

        return max;
    }
}
