namespace DailyLeetcode.Arrays;
public class MajorityElements
{
    public static int MajorityElement(int[] nums)
    {
        int count = 0, majority = 0;

        SortedArray(nums);

        int iterator = 0, j_iteirator = 0;

        while (j_iteirator < nums.Length)
        {
            if (nums[iterator] == nums[j_iteirator])
            {
                count++;
                j_iteirator++;

                if (count > nums.Length / 2)
                    majority = nums[iterator];
            }
            else
            {
                iterator = j_iteirator;
                count = 0;
            }
        }

        return majority;
    }
    private static void SortedArray(int[] nums)
    {
        int iterator = 0, j_iteirator = 0;

        for (iterator = 0; iterator < nums.Length; iterator++)
        {
            int index = iterator;
            for (j_iteirator = iterator + 1; j_iteirator < nums.Length; j_iteirator++)
            {
                if (nums[index] > nums[j_iteirator])
                {
                    int temp = nums[iterator];
                    nums[index] = nums[j_iteirator];
                    nums[j_iteirator] = temp;
                }
            }
        }
    }
}
