namespace DailyLeetcode.Maths;
public class CommonFactors
{
    public static int CommonFactorss(int a, int b)
    {
        int k = 2, counter = 0;

        while (true)
        {
            if (k > a || k > b)
                break;

            if (a % k == 0 && b % k == 0)
                counter++;

            k++;
        }

        return counter + 1;
    }
}
