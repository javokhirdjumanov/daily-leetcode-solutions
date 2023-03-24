using System.Text.RegularExpressions;

namespace DailyLeetcode.Strings.Easies;
internal class DetectCapitalUses
{
    public static bool DetectCapitalUse(string word)
    {
        return
            Regex.IsMatch(word, @"^[A-Z]+$") ||
            Regex.IsMatch(word, @"^[a-z]+$") ||
            Regex.IsMatch(word, @"^[A-Z]{1}[a-z]*$");
    }
}
