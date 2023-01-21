namespace DailyLeetcode.Sorting;
public sealed class ArrayPairSum
{
    private int ArrayPairSums(int[] nums)
    {
        int summa = 0;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
        {
            int minimal = Math.Min(nums[i + 1], nums[i]);

            summa += minimal;
        }

        return summa;
    }
}
