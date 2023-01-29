namespace DailyLeetcode.Maths.Easies;
public sealed class AlternateDigitSum
{
    public static int AlternateDigitSumma(int n)
    {
        int summa = 0;
        bool ft = true;

        int reverse = ReverseNumber(n);

        while (reverse > 0)
        {
            if (ft)
            {
                summa += reverse % 10;
                ft = false;
            }
            else
            {
                summa -= reverse % 10;
                ft = true;
            }
            reverse /= 10;
        }

        return summa;
    }
    private static int ReverseNumber(int n)
    {
        int reverse = 0;
        while (n > 0)
        {
            reverse = reverse * 10 + n % 10;

            n /= 10;
        }

        return reverse;
    }
}
