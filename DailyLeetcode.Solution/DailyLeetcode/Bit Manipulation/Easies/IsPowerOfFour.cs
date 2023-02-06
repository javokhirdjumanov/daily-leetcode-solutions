namespace DailyLeetcode.Bit_Manipulation.Easies;
public sealed class IsPowerOfFour
{
    public static bool IsPowerOfFours(int n)
    {
        if (n == 0 || n < 0) return false;
        int check = 0;

        while (n > 1)
        {
            check += n % 4;

            n /= 4;
        }
        if (check == 0)
            return true;

        return false;
    }
}
