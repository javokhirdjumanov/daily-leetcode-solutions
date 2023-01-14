namespace DailyLeetcode.Strings.NumOfStrings;
public sealed class NumOfStrings
{
    public static int NumOfStringss(string[] patterns, string word)
    {
        int result = 0;

        for (int i = 0; i < patterns.Length; i++)
        {
            if (word.Contains(patterns[i]))
                result++;
        }

        return result;
    }
}
