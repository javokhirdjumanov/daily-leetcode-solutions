namespace DailyLeetcode.HashTable.Easies;
internal class CheckAlmostEquivalents
{
    public static bool CheckAlmostEquivalent(string word1, string word2)
    {
        var set = new HashSet<string>();
        for (int i = 0; i < word1.Length; i++)
            set.Add(word1[i].ToString());

        var dict = NumberOfLettersInString(word1, word2, set);

        return dict.Values.Max(x => x) <= 3 && dict.Values.Min(x => x) >= -3;
    }
    public static Dictionary<string, int> NumberOfLettersInString(string word1, string word2, HashSet<string> set)
    {
        var dict = new Dictionary<string, int>();

        for (int i = 0; i < word1.Length; i++)
        {
            if (!dict.ContainsKey(word1[i].ToString()))
                dict.Add(word1[i].ToString(), 1);
            else
                dict[word1[i].ToString()]++;
        }

        for (int i = 0; i < word2.Length; i++)
        {
            if (!dict.ContainsKey(word2[i].ToString()))
                dict.Add(word2[i].ToString(), 1);
            else if (set.Contains(word2[i].ToString()))
                dict[word2[i].ToString()]--;
            else
                dict[word2[i].ToString()]++;
        }

        return dict;
    }
}
