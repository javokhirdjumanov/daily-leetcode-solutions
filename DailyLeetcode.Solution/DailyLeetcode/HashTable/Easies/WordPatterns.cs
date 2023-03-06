namespace DailyLeetcode.HashTable.Easies;
public class WordPatterns
{
    public static bool WordPattern(string pattern, string s)
    {
        Dictionary<string, string> map = new();
        HashSet<string> set = new();

        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (!map.ContainsKey(pattern[i].ToString()))
            {
                if (!set.Contains(words[i]))
                {
                    map.Add(pattern[i].ToString(), words[i]);
                    set.Add(words[i]);
                }
                else
                    return false;
            }
            else
                if (map[pattern[i].ToString()] != words[i])
                return false;
        }

        return true;
    }
}
