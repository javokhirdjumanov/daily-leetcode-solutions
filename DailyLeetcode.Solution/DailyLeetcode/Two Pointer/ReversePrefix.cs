using System.Text;

namespace DailyLeetcode.Two_Pointer;
public class ReversePrefix
{
    public static string ReversePrefixs(string word, char ch)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ch)
            {
                sb.Append(ReverseString(word.Substring(0, i + 1)));
                sb.Append(word.Substring(i + 1, word.Length - i - 1));

                return sb.ToString();
            }
        }

        return word;
    }
    private static string ReverseString(string word)
    {
        var sb = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            sb.Append(word[i]);
        }
        return sb.ToString();
    }
}
