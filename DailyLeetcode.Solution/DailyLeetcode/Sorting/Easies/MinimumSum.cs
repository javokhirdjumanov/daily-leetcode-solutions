namespace DailyLeetcode.Sorting.Easies;
public sealed class MinimumSum
{
    public int MinimumSums(int num)
    {
        int[] shit = Convert.ToString(num)
            .Select(c => c - '0').ToArray();

        Array.Sort(shit);

        return
            shit[0] * 10 + shit[2] + shit[1] * 10 + shit[3];

    }
}
