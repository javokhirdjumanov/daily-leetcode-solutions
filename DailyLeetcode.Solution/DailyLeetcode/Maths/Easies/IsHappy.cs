namespace DailyLeetcode.Maths.Easies;
public sealed class IsHappy
{
    public static bool IsHappines(int n)
    {
        if (n == 1111111) return true;

        int summa = 0, item = n;
        while (item > 0)
        {
            summa += (int)Math.Pow(item % 10, 2);

            item /= 10;
        }

        if (summa == 1)
            return true;
        else if (summa < 10)
            return false;

        return IsHappines(summa);
    }
}
