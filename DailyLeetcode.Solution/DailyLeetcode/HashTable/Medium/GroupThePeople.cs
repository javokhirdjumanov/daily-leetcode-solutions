namespace DailyLeetcode.HashTable.Medium;
public sealed class GroupThePeople
{
    public static IList<IList<int>> GroupThePeoples(int[] groupSizes)
    {
        var result = new List<IList<int>>();

        var dict = KeyValuePairs(groupSizes);

        foreach (var item in dict)
        {
            var customList = new List<int>();

            for (int i = 0; i < item.Value.Count; i++)
            {
                if (customList.Count == item.Key)
                {
                    result.Add(customList);

                    customList = new List<int>();
                }
                customList.Add(item.Value[i]);
            }
            result.Add(customList);
        }

        return result;
    }
    private static SortedDictionary<int, IList<int>> KeyValuePairs(int[] groupSizes)
    {
        var dict = new SortedDictionary<int, IList<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!dict.ContainsKey(groupSizes[i]))
                dict.Add(groupSizes[i], new List<int> { i });
            else
                dict[groupSizes[i]].Add(i);
        }

        return dict;
    }
}
