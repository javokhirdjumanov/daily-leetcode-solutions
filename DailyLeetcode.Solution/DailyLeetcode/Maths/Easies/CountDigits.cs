namespace DailyLeetcode.Maths.Easies;
public sealed class CountDigits
{
    public static int CountDigitss(int num)
    {
        int temp = num, counter = 0;

        while (temp > 0)
        {
            if (num % (temp % 10) == 0)
                counter++;

            temp /= 10;
        }

        return counter;
    }
}

