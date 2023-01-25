namespace DailyLeetcode.HashTable.Easies;
public class CountBalls
{
    public static int CountBallss(int lowLimit, int highLimit)
    {
        var dict = new Dictionary<int, int>();

        for (int i = lowLimit; i <= highLimit; i++)
        {
            int summa = 0;
            int param = i;

            while (param > 0)
            {
                summa += param % 10;

                param /= 10;
            }

            if (!dict.ContainsKey(summa))
                dict.Add(summa, 1);
            else
                dict[summa]++;
        }

        return dict.Values.Max();
    }
}
