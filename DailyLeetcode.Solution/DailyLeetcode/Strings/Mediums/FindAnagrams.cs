namespace DailyLeetcode.Strings.Mediums;
public sealed class FindAnagrams
{
    public static IList<int> FindAnagramss(string s, string p)
    {
        var result = new List<int>();
        for (int i = 0; i < s.Length - p.Length + 1; i++)
        {
            string cut = s.Substring(i, p.Length);
            if (IsAnagramm(cut, p))
                result.Add(i);
        }

        return result;
    }
    private static bool IsAnagramm(string cut, string p)
    {
        int[] chars = new int[26];

        for (int i = 0; i < cut.Length; i++)
            chars[cut[i] - 97]++;

        for (int i = 0; i < p.Length; i++)
            chars[p[i] - 97]--;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != 0)
                return false;
        }

        return true;
    }
}
