namespace DailyLeetcode.Maths.Mediums;
public sealed class CountDistinctIntegers
{
    private static int CountDistinctIntegerss(int[] nums)
    {
        var list = new List<int>(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int temp = ReverseInteger(nums[i]);

            list.Add(temp);
        }

        var set = new HashSet<int>(list);

        return set.Count;
    }
    private static int ReverseInteger(int number)
    {
        int summa = 0;

        while (number > 0)
        {
            summa = summa * 10 + number % 10;

            number /= 10;
        }

        return summa;
    }
}