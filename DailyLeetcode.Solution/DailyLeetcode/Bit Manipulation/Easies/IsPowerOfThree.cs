namespace DailyLeetcode.Bit_Manipulation.Easies;
public sealed class IsPowerOfThree
{
    public static bool IsPowerOfThrees(int n)
    {
        if (n == 0 || n < 0) return false;

        int check = 0;

        while (n > 1)
        {
            check += n % 3;

            n /= 3;
        }

        if (check == 0) return true;

        return false;
    }
}
