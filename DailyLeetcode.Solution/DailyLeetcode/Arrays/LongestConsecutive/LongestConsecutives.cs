using System.Diagnostics.Metrics;

namespace DailyLeetcode.Arrays.LongestConsecutive;

public class LongestConsecutives
{
    public static int LongestConsecutive(int[] nums)
    {
        int counter = 1, number = 0;

        if (nums.Length == 0)
            counter = 0;

        return IntReturn(nums, counter, number);
    }
    private static int IntReturn(int[] nums, int counter, int number)
    {
        Array.Sort(nums);

        for (int iterator = 1; iterator < nums.Length; iterator++)
        {
            if (nums[iterator - 1] != nums[iterator])
            {
                if ((nums[iterator - 1] + 1) == nums[iterator])
                    counter++;
                else
                {
                    if (counter > number)
                        number = counter;

                    counter = 1;
                }
            }
        }
        if (counter > number)
            number = counter;

        return number;
    }
}
