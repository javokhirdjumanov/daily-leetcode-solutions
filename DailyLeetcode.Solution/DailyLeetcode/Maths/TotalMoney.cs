namespace DailyLeetcode.Maths;
public sealed class TotalMoney
{
    public static int TotalMoneies(int n)
    {
        int summa = 0;
        int dollarSumma = 1, dayOfWeek = 1, level = 0;

        while (n > 0)
        {
            summa += dayOfWeek;

            dayOfWeek++;
            if (dayOfWeek == 8 + level)
            {
                dollarSumma += 1;
                dayOfWeek = dollarSumma;

                level++;
            }
            n--;
        }

        return summa;
    }
}
