namespace DailyLeetcode.HashTable.Mediums;
public class CountKDifference
{
    public static int CountKDifferences(int[] nums, int k)
    {
        int counter = 0, left = 0, right = 1;
        while (left < nums.Length)
        {
            if (right == nums.Length)
            {
                left++;
                right = left + 1;
                continue;
            }

            int temp1 = Math.Abs(nums[right] - nums[left]);
            int temp2 = Math.Abs(nums[left] - nums[right]);

            if (temp1 == k || temp2 == k)
                counter++;

            right++;
        }

        return counter;
    }
}
