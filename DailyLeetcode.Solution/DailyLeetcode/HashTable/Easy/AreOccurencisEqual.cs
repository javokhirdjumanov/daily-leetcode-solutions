namespace DailyLeetcode.HashTable.Easy;
public sealed class AreOccurencisEqual
{
    public static bool AreOccurrencesEquals(string s)
    {
        var dict = new Dictionary<string, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i].ToString()))
            {
                dict.Add(s[i].ToString(), 1);
            }
            else
                dict[s[i].ToString()]++;
        }

        int temp = dict[s[0].ToString()];

        foreach (var item in dict)
        {
            if (item.Value != temp)
                return false;
        }

        return true;
    }
}
