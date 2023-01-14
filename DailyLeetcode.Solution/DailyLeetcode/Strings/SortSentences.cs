namespace DailyLeetcode.Strings;
public class SortSentences
{
    public static string SortSentence(string s)
    {
        var sortedDict = new SortedDictionary<int, string>();

        string[] words = s.Split(' ');

        for (int iterator = 0; iterator < words.Length; iterator++)
        {
            string word = words[iterator];
            sortedDict.Add(word[word.Length - 1] - '0', word.Substring(0, word.Length - 1));
        }

        return
            string.Join(" ", sortedDict.Values.ToList());
    }
}
