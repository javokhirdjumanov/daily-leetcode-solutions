namespace DailyLeetcode.Strings.Mediums;
public sealed class BuddyStrings
{
    public static bool BuddyStringss(string s, string goal)
    {
        if (s.Length != goal.Length) return false;

        if (PrivateScore(s, goal))
            return true;

        List<string> ls = new(); List<string> lg = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != goal[i])
            {
                ls.Add(s[i].ToString());
                lg.Add(goal[i].ToString());
            }
        }
        if (ls.Count != 2) return false;

        if (ls[0] == lg[1] && ls[1] == lg[0]) return true;

        return false;
    }
    public static bool PrivateScore(string s, string goal)
    {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i].ToString()))
                dict.Add(s[i].ToString(), 1);
            else
                dict[s[i].ToString()]++;
        }

        return s == goal && dict.Values.Max() > 1;
    }
}
