using System.Text;

namespace DailyLeetcode.Strings.ReplaceDigits;
public sealed class ReplaceDigits1solution
{
    public static string ReplaceDigitss(string s)
    {
        StringBuilder sb = new();

        if (s.Length == 1)
            return sb.Append(s).ToString();

        for (int i = 1; i < s.Length; i++)
        {
            if (char.IsDigit(s[i - 1]))
            {
                StringBuilder sb1 = new();
                sb1.Append(s[i - 1]);

                if (char.IsDigit(s[i]))
                    sb1.Append(s[i]);

                sb.Append(TearLetter(s[i - 2], int.Parse(sb1.ToString())));

                if (i == s.Length - 1 && char.IsLetter(s[i]))
                    sb.Append(s[i].ToString());
            }
            else if (i == s.Length - 1)
            {
                sb.Append(s[i - 1].ToString());
                sb.Append(TearLetter(s[i - 1], s[i] - 48));
            }
            else
                sb.Append(s[i - 1]);
        }

        return sb.ToString();
    }
    private static string TearLetter(char letter, int number)
    {
        int temp = 0;
        var letters = new string[]{
            "a", "b", "c", "d", "e","f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o","p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == letter.ToString())
            {
                temp = i + number;
                break;
            }
        }
        return letters[temp];
    }
}
