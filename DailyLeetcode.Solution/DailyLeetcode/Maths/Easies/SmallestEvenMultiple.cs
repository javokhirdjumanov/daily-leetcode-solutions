namespace DailyLeetcode.Maths.Easies;
public sealed class SmallestEvenMultiple
{
    private static int SmallestEvenMultiples(int n)
    {
        for (int i = n; i <= 150 * n; i++)
        {
            if (i % 2 == 0 && i % n == 0)
                return i;
        }

        return 0;
    }
}
