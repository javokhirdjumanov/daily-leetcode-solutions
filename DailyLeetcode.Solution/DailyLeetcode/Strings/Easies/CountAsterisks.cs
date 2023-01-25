namespace DailyLeetcode.Strings.Easies;
public class CountAsterisks
{
    public static int CountAsteriskss(string s)
    {
        int counter = 0, check = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '|')
            {
                if (check >= 2)
                {
                    check = 0;
                    check++;
                }
                else
                    check++;
            }
            else if ((check == 0 || check == 2) && s[i] == '*')
            {
                counter++;
                check = 0;
            }
        }

        return counter;
    }
}
