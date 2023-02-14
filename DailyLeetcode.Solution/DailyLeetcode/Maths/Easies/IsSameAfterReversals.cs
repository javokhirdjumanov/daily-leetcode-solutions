namespace DailyLeetcode.Maths.Easies;
public sealed class IsSameAfterReversals
{
    public static bool IsSameAfterReversalss(int num)
    {
        int reverb = 0, temp = num;

        temp = ReverbNumber(temp, reverb);

        reverb = 0;

        return ReverbNumber(temp, reverb) == num;
    }
    private static int ReverbNumber(int temp, int reverb)
    {
        while (temp > 0)
        {
            reverb = reverb * 10 + temp % 10;

            temp /= 10;
        }

        return reverb;
    }
}
