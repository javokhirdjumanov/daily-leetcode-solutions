namespace DailyLeetcode.Two_Pointer.Mediums;
public sealed class RearrangeArray
{
    public static int[] RearrangeArrays(int[] nums)
    {
        int[] result = new int[nums.Length];

        int index = 0, positive = 0, negative = 1;

        while (index < nums.Length)
        {
            if (nums[index] > 0)
            {
                result[positive] = nums[index];
                positive += 2;
            }
            else
            {
                result[negative] = nums[index];
                negative += 2;
            }
            index++;
        }

        return result;
    }
}
