namespace DailyLeetcode.Binary_Search.Easy;
public sealed class MinOperations
{
    private static int MinOperationss(int[] nums)
    {
        int steps = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                steps += ((nums[i - 1] + 1) - nums[i]);
                nums[i] = nums[i - 1] + 1;
            }
        }

        return steps;
    }
}
