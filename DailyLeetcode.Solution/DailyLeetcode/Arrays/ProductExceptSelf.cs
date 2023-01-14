namespace DailyLeetcode.Arrays;
public class ProductExceptSelf
{
    public static int[] ProductExceptSelfs(int[] nums)
    {
        var result = new int[nums.Length];

        result[0] = 1;
        for (int iterator = 1; iterator < nums.Length; iterator++)
        {
            result[iterator] = result[iterator - 1] * nums[iterator - 1];
        }

        int temp = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= temp;

            temp *= nums[i];
        }

        return result;
    }
}
