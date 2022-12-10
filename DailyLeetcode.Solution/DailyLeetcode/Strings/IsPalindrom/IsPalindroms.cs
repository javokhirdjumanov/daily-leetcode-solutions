using System.Text;

namespace DailyLeetcode.Strings.IsPalindrom;
public class IsPalindroms
{
    public static bool IsPalindrome(string s)
    {
        StringBuilder sb = new StringBuilder();

        if (s == " ")
            return true;

        s = s.ToLower();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]) || char.IsDigit(s[i]))
                sb.Append(s[i]);
        }

        int left = 0, right = sb.Length - 1;
        while (left < right)
        {
            if (!(sb[left] == sb[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
