namespace DailyLeetcode.Maths.Easies;
public sealed class AddDigits
{
    public static int AddDigitss(int num)
    {
        int summa = 0;
        while (num > 0)
        {
            summa += num % 10;
            num /= 10;
        }

        if (summa > 9)
            return AddDigitss(summa);

        return summa;
    }
}
