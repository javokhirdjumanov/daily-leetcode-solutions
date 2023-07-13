namespace DailyLeetcode.Bit_Manipulation.Easies;
public sealed class XorOperation
{
    public static int XorOperations(int n, int start)
    {
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int temp = start + 2 * i;
            result ^= temp;
        }

        return result;
    }
}
