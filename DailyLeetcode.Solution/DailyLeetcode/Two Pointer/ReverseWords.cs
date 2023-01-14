using System.Text;

namespace DailyLeetcode.Two_Pointer.ReverseWords;

public sealed class ReverseWords
{
    public static string ReverseWordss(string s)
    {
        var sb = new StringBuilder();
        string[] words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            for (int j = word.Length - 1; j >= 0; j--)
            {
                sb.Append(word[j]);
            }
            sb.Append(' ');
        }
        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}

