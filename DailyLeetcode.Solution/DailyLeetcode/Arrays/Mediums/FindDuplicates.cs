namespace DailyLeetcode.Arrays.Mediums;
internal class FindDuplicates
{
    public static int FindDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (!dict.ContainsKey(i))
                dict.Add(i, 1);
            else
                dict[i]++;
        }

        foreach (var item in dict)
        {
            if (item.Value > 1)
                return item.Key;
        }

        return 0;
    }
}
