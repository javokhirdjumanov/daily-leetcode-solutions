namespace DailyLeetcode.Strings.Easies;
public sealed class CountWords
{
    public static int CountWordss(string[] words1, string[] words2)
    {
        int count = 0;

        var dict_words1 = GenerationDict(words1);
        var dict_words2 = GenerationDict(words2);

        var set = new HashSet<string>();
        foreach (var item in dict_words1)
        {
            if (item.Value == 1)
                set.Add(item.Key);
        }

        foreach (var item in dict_words2)
        {
            if (item.Value == 1)
            {
                if (set.Contains(item.Key))
                    count++;
            }
        }

        return count;
    }
    private static Dictionary<string, int> GenerationDict(string[] words)
    {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (!dict.ContainsKey(words[i]))
                dict.Add(words[i], 1);
            else
                dict[words[i]]++;
        }

        return dict;
    }
}
