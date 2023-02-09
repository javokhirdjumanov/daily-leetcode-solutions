namespace DailyLeetcode.Maths.Easies;
public sealed class IsUgly
{
    public static bool IsUglies(int n)
    {
        if (n <= 0) return false;

        foreach (int item in new int[] { 2, 3, 5 })
            n = IsPrime(n, item);

        return n == 1;
    }
    public static int IsPrime(int n, int item)
    {
        while (n % item == 0)
            n /= item;

        return n;
    }
}
