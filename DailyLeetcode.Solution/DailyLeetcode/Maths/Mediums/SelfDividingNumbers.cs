namespace DailyLeetcode.Maths.Mediums;
public sealed class SelfDividingNumbers
{
    public static IList<int> SelfDividingNumberss(int left, int right)
    {
        bool isnt = false;
        var result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            int temp = i;
            while (temp > 0)
            {
                if (temp % 10 == 0)
                {
                    isnt = true;
                    break;
                }

                int param = temp;

                if (temp > 9)
                    param = temp % 10;

                if (i % param == 0)
                {
                    temp /= 10;
                    isnt = false;
                }
                else
                {
                    isnt = true;
                    break;
                }
            }

            if (!isnt)
                result.Add(i);
        }
        return result;
    }
}
