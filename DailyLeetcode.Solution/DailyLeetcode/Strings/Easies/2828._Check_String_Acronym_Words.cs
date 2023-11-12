namespace DailyLeetcode.Strings.Easies
{
    public class _2828
    {
        public bool IsAcronym(IList<string> words, string s)
        {
            if (words.Count != s.Length)
                return false;

            for (int i = 0; i < words.Count; i++)
                if (words[i][0] != s[i])
                    return false;

            return true;
        }
    }
}
