namespace DailyLeetcode.Bit_Manipulation.Easies;
internal class CountBitss
{
    public static int[] CountBits(int n)
    {
        var list = new List<int>();
        for (int i = 0; i <= n; i++)
        {
            int sum = Convert
                .ToString(i, 2)
                .Select(c => int.Parse(c.ToString()))
                .Sum();

            list.Add(sum);
        }

        return list.ToArray();
    }
}
