namespace DailyLeetcode.Sorting.Easies;
public sealed class FindFinalValue
{
    public static int FindFinalValues(int[] nums, int original)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == original)
                original = original * 2;
        }

        return original;
    }
}
