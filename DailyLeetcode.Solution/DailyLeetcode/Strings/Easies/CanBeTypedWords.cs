namespace DailyLeetcode.Strings.Easies;
public sealed class CanBeTypedWords
{
    public static int CanBeTypedWordss(string text, string brokenLetters)
    {
        int count = 0;

        string[] words = text.Split(' ');
        var set = FilledHashSet(brokenLetters);

        for (int i = 0; i < words.Length; i++)
        {
            string temp = words[i];
            for (int j = 0; j < temp.Length; j++)
            {
                if (set.Contains(temp[j].ToString()))
                {
                    count--;
                    break;
                }
            }
            count++;
        }
        return count;
    }
    private static HashSet<string> FilledHashSet(string brokenLetters)
    {
        var set = new HashSet<string>();

        foreach (var letter in brokenLetters)
            set.Add(letter.ToString());

        return set;
    }
}