namespace DailyLeetcode.Arrays.Easies;
public sealed class DifferenceOfSum
{
    public static int DifferenceOfSumma(int[] nums)
    {
        int summa = 0;

        for (int i = 0; i < nums.Length; i++)
            summa += nums[i];

        for (int i = 0; i < nums.Length; i++)
            summa -= FragmentationNumber(number: nums[i]);

        return summa;
    }

    private static int FragmentationNumber(int number)
    {
        int summa = 0;

        while (number > 0)
        {
            summa += number % 10;

            number /= 10;
        }

        return summa;
    }
}
