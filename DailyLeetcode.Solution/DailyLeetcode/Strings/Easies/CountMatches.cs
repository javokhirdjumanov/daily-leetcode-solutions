namespace DailyLeetcode.Strings.Easies;
public class CountMatches
{
    public static int CountMatchess(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int result = 0;

        if (ruleKey is "type")
        {
            for (int i = 0; i < items.Count; i++)
                if (items[i][0] == ruleValue)
                    result++;
        }
        else if (ruleKey is "color")
        {
            for (int i = 0; i < items.Count; i++)
                if (items[i][1] == ruleValue)
                    result++;
        }
        else if (ruleKey is "name")
        {
            for (int i = 0; i < items.Count; i++)
                if (items[i][2] == ruleValue)
                    result++;
        }

        return result;
    }
}
