namespace DailyLeetcode.Arrays;
public class SortColor
{
    public static string SortColors(int[] nums)
    {
        for (int iterator = 0; iterator < nums.Length; iterator++)
        {
            int majority = iterator;
            for (int j_iteirator = iterator + 1; j_iteirator < nums.Length; j_iteirator++)
            {
                if (nums[majority] > nums[j_iteirator])
                {
                    int temp = nums[iterator];
                    nums[majority] = nums[j_iteirator];
                    nums[j_iteirator] = temp;
                }
            }
        }

        return string.Join(" ", nums);
    }
}
