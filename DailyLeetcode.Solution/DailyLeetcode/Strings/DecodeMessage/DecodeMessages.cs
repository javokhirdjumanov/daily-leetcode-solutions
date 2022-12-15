using System.Text;

namespace DailyLeetcode.Strings.DecodeMessage;
public class DecodeMessages
{
    private static string DecodeMessage(string key, string message)
    {
        string[] letters =
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
        };

        var sb = AddStringBuilder(key);
        var dict = AddDictinary(sb, letters);

        sb.Clear();

        for (int i = 0; i < message.Length; i++)
        {
            string letter = message[i].ToString();

            if (dict.ContainsKey(letter))
                sb.Append(dict[letter]);

            else if (message[i] is ' ')
                sb.Append(" ");
        }

        return sb.ToString();
    }
    private static StringBuilder AddStringBuilder(string key)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < key.Length; i++)
        {
            if (key[i] is not ' ')
                sb.Append(key[i]);
        }

        return sb;
    }
    private static Dictionary<string, string> AddDictinary(StringBuilder sb, string[] letters)
    {
        var dict = new Dictionary<string, string>();
        int k = 0;

        for (int i = 0; i < sb.Length; i++)
        {
            if (!dict.ContainsKey(sb[i].ToString()))
                dict.Add(sb[i].ToString(), letters[k++]);
        }

        return dict;
    }
}
