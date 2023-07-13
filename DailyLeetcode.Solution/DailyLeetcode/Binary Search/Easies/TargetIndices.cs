namespace DailyLeetcode.Binary_Search;
public sealed class TargetIndices
{
    public static IList<int> TargetIndicess(int[] nums, int target)
    {
        var result = new List<int>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                result.Add(i);
        }

        return result;
    }
}
