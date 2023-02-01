namespace DailyLeetcode.Two_Pointer.Easies;
public sealed class SortArrayByParityII
{
    public static int[] SortArrayByParitiesII(int[] nums)
    {
        int[] result = new int[nums.Length];

        int even = 0, odd = 1, index = 0;
        while (index < nums.Length)
        {
            if (nums[index] % 2 == 0)
            {
                result[even] = nums[index];
                even += 2;
            }
            else
            {
                result[odd] = nums[index];
                odd += 2;
            }
            index++;
        }

        return result;
    }
}
