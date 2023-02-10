namespace DailyLeetcode.Strings.Easies;
public sealed class CountSegments
{
    public static int CountSegmentss(string s)
    {
        s = TakingExtraSpaces(s);

        if (s == "") return 0;

        string[] words = s.Split(" ");

        return words.Length;
    }
    private static string TakingExtraSpaces(string s)
    {
        if (s == "") return "";

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] is ' ' && s[i - 1] is ' ')
            {
                s = s.Remove(i, 1);
                i--;
            }
        }
        if (s[s.Length - 1] is ' ')
        {
            s = s.Remove(s.Length - 1, 1);
            if (s == "") return "";
        }

        if (s[0] is ' ')
            s = s.Remove(0, 1);

        return s;
    }
}
