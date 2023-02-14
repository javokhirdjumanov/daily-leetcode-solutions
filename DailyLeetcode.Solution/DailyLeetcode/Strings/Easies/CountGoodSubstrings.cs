namespace DailyLeetcode.Strings.Easies;
public sealed class CountGoodSubstrings
{
    public static int CountGoodSubstringss(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length - 2; i++)
        {
            string temp = s.Substring(i, 3);

            if (!(temp[0] == temp[1] || temp[0] == temp[2] || temp[2] == temp[1]))
                count++;
        }

        return count;
    }
}
