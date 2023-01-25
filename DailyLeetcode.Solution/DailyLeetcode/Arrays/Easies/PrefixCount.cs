namespace DailyLeetcode.Arrays.Easies;
public sealed class PrefixCount
{
    public static int PrefixCounts(string[] words, string pref)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= pref.Length)
            {
                string s = words[i].Substring(0, pref.Length);
                if (s == pref)
                    count++;
            }
        }

        return count;
    }
}
