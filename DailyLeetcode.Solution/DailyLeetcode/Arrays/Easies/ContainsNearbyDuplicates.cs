namespace DailyLeetcode.Arrays.Easies;
public class ContainsNearbyDuplicates
{
    public static bool ContainsNearbyDuplicate(int[] nums, int j_iteirator)
    {
        int left = 0, right = left + 1;

        while (left < nums.Length && right < nums.Length)
        {
            if (nums[left] == nums[right])
            {
                if (Math.Abs(left - right) <= j_iteirator)
                    return true;
            }

            right++;

            if (right == nums.Length)
            {
                left++;
                right = left + 1;
            }
        }

        return false;
    }
}
