namespace DailyLeetcode.Sorting.Mediums;
public sealed class MinPairSum
{
    public static int MinPairSumma(int[] nums)
    {
        int maximal = 0;
        int left = 0, right = nums.Length - 1;

        Array.Sort(nums);

        while (left < right)
        {
            int temp =
                nums[right--] + nums[left++];

            maximal = Math.Max(maximal, temp);
        }

        return maximal;
    }
}
