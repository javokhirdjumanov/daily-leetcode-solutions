namespace DailyLeetcode.Strings.Easies;
public class TruncateSentence
{
    public static string TruncateSentences(string s, int k)
    {
        var result = new List<string>();
        int index = 0;

        string[] words = s.Split(' ');

        while (k > 0)
        {
            result.Add(words[index].ToString());

            index++;
            k--;
        }
        return string.Join(" ", result.ToArray());
    }
}
