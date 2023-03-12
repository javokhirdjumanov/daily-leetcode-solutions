namespace DailyLeetcode.Strings.Mediums;
internal class MinStepss
{
    public static int MinSteps(string s, string t)
    {
        int[] chars = new int[26];

        for (int i = 0; i < s.Length; i++)
            chars[s[i] - 'a']++;

        for (int i = 0; i < t.Length; i++)
        {
            if (chars[t[i] - 'a'] > 0)
                chars[t[i] - 'a']--;
        }

        return chars.AsEnumerable().Sum();
    }
}
