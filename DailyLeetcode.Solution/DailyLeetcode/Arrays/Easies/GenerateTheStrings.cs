using System.Text;
namespace DailyLeetcode.Arrays.Easies;
public sealed class GenerateTheStrings
{
    public static string GenerateTheString(int n)
    {
        var sb = new StringBuilder();
        if (n % 2 == 0)
        {
            while (n > 1)
            {
                sb.Append('a');
                n--;
            }
            sb.Append('b');
        }
        else
        {
            while (n > 0)
            {
                sb.Append('a');
                n--;
            }
        }
        return sb.ToString();
    }
}
// Link: https://leetcode.com/submissions/detail/914579048/
