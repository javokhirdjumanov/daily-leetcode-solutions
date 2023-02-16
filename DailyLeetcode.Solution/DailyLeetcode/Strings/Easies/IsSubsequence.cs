namespace DailyLeetcode.Strings.Easies;
public class IsSubsequence
{
    public static bool IsSubsequences(string s, string t)
    {
        if (s == "") return true;
        int indexS = 0, indexT = 0; ;

        while (indexS < s.Length && indexT < t.Length)
        {
            if (t[indexT].ToString() == s[indexS].ToString())
                indexS++;
            else
            {
                t = t.Remove(indexT, 1);
                indexT--;
            }
            indexT++;
        }
        if (t.Length > s.Length)
            t = t.Remove(s.Length);

        return s == t;
    }
}
