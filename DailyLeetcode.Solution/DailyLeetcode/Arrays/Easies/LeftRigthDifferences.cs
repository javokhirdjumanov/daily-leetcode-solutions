namespace DailyLeetcode.Arrays.Easies;
public sealed class LeftRigthDifferences
{
    public static int[] LeftRigthDifference(int[] nums)
    {
        // 1 solution
        var result = new List<int>();
        int slow = 0, left = slow - 1, right = slow + 1, summa = 0;
        while (slow < nums.Length)
        {
            while (left >= 0)
                summa += nums[left--];
            while (right < nums.Length)
                summa -= nums[right++];
            slow++; left = slow - 1; right = slow + 1;
            result.Add((int)Math.Abs(summa));
            summa = 0;
        }
        return result.ToArray();

        // 2 solution
        // int[] rightSumma = new int[nums.Length];
        // int[] leftSumma = new int[nums.Length];

        // int index = 0; leftSumma[0] = 0;
        // while (index < nums.Length - 1)
        // {
        //     leftSumma[index + 1] = leftSumma[index] + nums[index];
        //     index++;
        // }

        // index = nums.Length - 1; rightSumma[rightSumma.Length - 1] = 0;
        // while (index > 0)
        // {
        //     rightSumma[index - 1] = rightSumma[index] + nums[index];
        //     index--;
        // }
        // for (int i = 0; i < rightSumma.Length; i++)
        //     rightSumma[i] = Math.Abs(leftSumma[i] - rightSumma[i]);
        // return rightSumma;
    }
}
