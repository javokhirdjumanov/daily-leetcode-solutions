namespace DailyLeetcode.HashTable.Mediums;
internal class FindAndReplacePattern
{
    public static IList<string> FindAndReplacePatterns(string[] words, string pattern)
    {
        var result = new List<string>();

        var has = ForCheck(pattern);
        for (int i = 0; i < words.Length; i++)
        {
            var temporary = ForCheck(words[i]);
            if (temporary.Count != has.Count)
                continue;

            bool areequal = temporary.SequenceEqual(has, new ListComparer());

            if (areequal)
                result.Add(words[i]);
        }
        return result;
    }
    public static List<List<int>> ForCheck(string str)
    {
        var dict = new Dictionary<string, List<int>>();
        for (int i = 0; i < str.Length; i++)
        {
            if (!dict.ContainsKey(str[i].ToString()))
                dict.Add(str[i].ToString(), new List<int> { i });
            else
                dict[str[i].ToString()].Add(i);
        }
        return dict.Values.Select(list => list.ToList()).ToList();
    }
}
internal class ListComparer : IEqualityComparer<List<int>>
{
    public bool Equals(List<int> x, List<int> y) => x.SequenceEqual(y);
    public int GetHashCode(List<int> obj) => obj.GetHashCode();
}
