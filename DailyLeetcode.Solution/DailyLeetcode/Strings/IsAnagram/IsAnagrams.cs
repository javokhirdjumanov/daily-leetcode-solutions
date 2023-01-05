namespace DailyLeetcode.Strings.IsAnagram;
public class IsAnagrams
{
    private static bool IsAnagram(string s, string t)
    {
        var array = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            array[s[i] - '0']++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            array[t[i] - '0']--;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
                return false;
        }

        return true;
    }
}
