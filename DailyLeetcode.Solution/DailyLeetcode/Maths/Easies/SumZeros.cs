namespace DailyLeetcode.Maths.Easies;
public sealed class SumZeros
{
    private static int[] SumZero(int n)
    {
        var list = new List<int>();

        for (int i = 1; i < n; i++)
            list.Add(i);

        list.Add(-list.Sum(x => x));

        return list.ToArray();
    }
}
