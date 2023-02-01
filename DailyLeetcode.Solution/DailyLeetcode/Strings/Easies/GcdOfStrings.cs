using System.Text;
namespace DailyLeetcode.Strings.Easies;
public sealed class GcdOfStrings
{
    public static string GcdOfStringss(string str1, string str2)
    {
        string key = "";
        for (int i = str2.Length; i > 0; i--)
        {
            key = str2.Substring(0, i);

            if (str1.Length % key.Length == 0)
            {
                if (IsThereKeyInStr(str2, key))
                {
                    if (IsThereKeyInStr(str1, key))
                        return key;
                }
            }
            key = "";
        }
        return key;
    }
    private static bool IsThereKeyInStr(string s, string key)
    {
        var sb = new StringBuilder();
        int length = s.Length / key.Length;

        while (length > 0)
        {
            sb.Append(key);
            length--;
        }

        if (sb.ToString() == s)
            return true;

        return false;
    }
}