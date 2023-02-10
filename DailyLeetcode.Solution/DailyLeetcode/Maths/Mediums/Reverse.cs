namespace DailyLeetcode.Maths.Mediums;
public sealed class Reverse
{
    public static int ReverseInteger(int x)
    {
        // checking the number for negativity
        bool manfiy = false;
        if (x < 0)
        {
            if (x == int.MinValue)
                x = x + 1;

            x = Math.Abs(x);
            manfiy = true;
        }

        // reverse integer
        long summa = 0;
        while (x > 0)
        {
            summa = summa * 10 + x % 10;

            if (summa > int.MaxValue)
                return 0;

            x /= 10;
        }

        // if number is negative
        if (manfiy)
            return ((int)summa * -1);

        // else
        return (int)summa;
    }
}
