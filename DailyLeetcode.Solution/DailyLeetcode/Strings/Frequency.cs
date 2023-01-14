namespace DailyLeetcode.Strings;
public class FrequncySort
{
    public static void Frequency()
    {
        string s = "Aabb";

        var dictionary = FrequencyDictionary(s);

        var consoleStr = FrequencyList(dictionary);

        Console.WriteLine(consoleStr);
    }
    private static Dictionary<char, int> FrequencyDictionary(string s)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();

        for (int iterator = 0; iterator < s.Length; iterator++)
        {
            if (!dictionary.ContainsKey(s[iterator]))
                dictionary.Add(s[iterator], 1);
            else
                dictionary[s[iterator]]++;
        }

        return dictionary;
    }
    private static string FrequencyList(Dictionary<char, int> dictionary)
    {
        List<char> listOfChars = new List<char>();

        var sortedDict = dictionary.OrderByDescending(x => x.Value);

        foreach (var item in sortedDict)
        {
            for (int iterator = 0; iterator < item.Value; iterator++)
                listOfChars.Add(item.Key);
        }

        return string.Join("", listOfChars);
    }
}
