namespace DailyLeetcode.Strings.Mediums;
public sealed class CheckInclusion
{
    public static bool CheckInclusions(string s1, string s2)
    {
        for (int i = 0; i < s2.Length - s1.Length + 1; i++)
        {
            var cut = s2.Substring(i, s1.Length);
            if (IsAnagram(s1, cut))
                return true;
        }

        return false;
    }
    public static bool IsAnagram(string s1, string cut)
    {
        int[] chars = new int[26];

        for (int i = 0; i < s1.Length; i++)
            chars[s1[i] - 97]++;

        for (int i = 0; i < cut.Length; i++)
            chars[cut[i] - 97]--;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != 0)
                return false;
        }
        return true;
    }
}
