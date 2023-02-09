using System.Text;
namespace DailyLeetcode.Strings.Easies;
public sealed class RotateString
{
    public static bool RotateStrings(string s, string goal)
    {
        var sb = new StringBuilder(s);

        int i = 0;
        while (i < s.Length)
        {
            sb.Append(s[i++]); sb.Remove(0, 1);

            if (sb.ToString() == goal)
                return true;
        }

        return false;
    }
}
