namespace DailyLeetcode.Arrays.Easies;
public sealed class IsMonotonic
{
    public static bool IsMonotonics(int[] nums)
    {
        var increasing = nums.OrderBy(x => x).ToArray();
        var decreasing = nums.OrderByDescending(x => x).ToArray();

        if (Enumerable.SequenceEqual(increasing, nums) || Enumerable.SequenceEqual(decreasing, nums))
            return true;

        return false;
    }
}
