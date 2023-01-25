namespace DailyLeetcode.Sorting.Easies;
public sealed class MinimumOperations
{
    public static int MinimumOperationss(int[] nums)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                set.Add(nums[i]);
        }

        return set.Count;
    }
}
