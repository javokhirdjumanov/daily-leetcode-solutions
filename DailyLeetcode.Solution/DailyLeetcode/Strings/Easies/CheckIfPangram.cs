namespace DailyLeetcode.Strings.Easies;
public class CheckIfPangram
{
    public static bool CheckIfPangrams(string sentence)
    {
        var set = new HashSet<string>();

        for (int i = 0; i < sentence.Length; i++)
        {
            set.Add(sentence[i].ToString());
        }

        if (set.Count >= 26)
            return true;

        return false;
    }
}
