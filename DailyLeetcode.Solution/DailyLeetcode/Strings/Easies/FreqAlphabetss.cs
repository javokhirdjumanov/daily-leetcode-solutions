using System.Text;
namespace DailyLeetcode.Strings.Easies;
internal class FreqAlphabetss
{
    public static string FreqAlphabets(string s)
    {
        var dict = new Dictionary<string, string>()
        { 
            {"1", "a"},{"2", "b"},{"3", "c"},{"4", "d"},{"5", "e"},{"6", "f"},
            {"7", "g"},{"8", "h"},{"9", "i"},{"10#", "j"},{"11#", "k"},
            {"12#", "l"},{"13#", "m"},{"14#", "n"},{"15#", "o"},{"16#", "p"},
            {"17#", "q"},{"18#", "r"},{"19#", "s"},{"20#", "t"},{"21#", "u"},
            {"22#", "v"},{"23#", "w"},{"24#", "x"},{"25#", "y"},{"26#", "z"}
        };
        var sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i].ToString() == "#")
            {
                sb.Insert(0, dict[s.Substring(i - 2, 3)]);
                i -= 2;
            }
            else
                sb.Insert(0, dict[s[i].ToString()]);
        }
        return sb.ToString();
    }
}
