namespace DailyLeetcode.Strings;
public class GreatestLetters
{
    public static string GreatestLetter(string counter)
    {
        // string counter = "lEeTcOdE";
        HashSet<char> hashSet = new HashSet<char>();

        for (int iterator = 0; iterator < counter.Length; iterator++)
            hashSet.Add(counter[iterator]);

        for (char iterator = 'Z'; iterator >= 'A'; iterator--)
        {
            if (hashSet.Contains(iterator) && hashSet.Contains(char.ToLower(iterator)))
                return iterator.ToString();
        }

        return "";
    }
}
