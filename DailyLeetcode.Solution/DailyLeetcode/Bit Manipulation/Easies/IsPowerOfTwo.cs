namespace DailyLeetcode.Bit_Manipulation.Easies;
public sealed class IsPowerOfTwo
{
    public static bool IsPowerOfTwos(int n)
    {
        if (n == 0 || n < 0) return false;

        int check = 0;

        while (n > 1)
        {
            check += n % 2;

            n /= 2;
        }
        if (check == 0)
            return true;

        return false;
    }
}
