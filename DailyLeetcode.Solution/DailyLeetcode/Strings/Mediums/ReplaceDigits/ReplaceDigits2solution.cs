using System.Text;

namespace DailyLeetcode.Strings.Mediums.ReplaceDigits;
public sealed class ReplaceDigits2solution
{
    public static string ReplaceDigits(string s)
    {
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= '0' && s[i] <= '9')
            {
                char temp1 = Convert.ToChar(s[i - 1]);
                int temp2 = Convert.ToInt32(s[i] - '0');

                sb.Append(temp1 + temp2);
            }
            else
                sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
