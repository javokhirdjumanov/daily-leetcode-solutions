namespace DailyLeetcode.HashTable.Easies;
public sealed class CountLargestGroup
{
    public static int CountLargestGroups(int n)
    {
        var dict = new Dictionary<int, IList<int>>();

        for (int i = 1; i <= n; i++)
        {
            int temp = i, summa = 0;

            while (temp > 0)
            {
                summa += temp % 10;

                temp /= 10;
            }

            if (!dict.ContainsKey(summa))
                dict.Add(summa, new List<int>() { i });
            else
                dict[summa].Add(i);
        }

        return MaxLengthFromDictValues(dict);
    }
    public static int MaxLengthFromDictValues(Dictionary<int, IList<int>> dict)
    {
        var dictionary = new SortedDictionary<int, int>();

        foreach (var item in dict)
        {
            if (!dictionary.ContainsKey(item.Value.Count))
                dictionary.Add(item.Value.Count, 1);
            else
                dictionary[item.Value.Count]++;
        }

        return dictionary.Values.Last();
    }
}
