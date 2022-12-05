namespace DailyLeetcode.Strings.CanConstruct;
public class CanConstructs
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;

        return AlphabetCounters(ransomNote, magazine);
    }
    private static bool AlphabetCounters(string ransomNote, string magazine)
    {
        var alphabets_counter = new int[26];

        foreach (var item in magazine)
            alphabets_counter[item - 'a']++;

        foreach (var item in ransomNote)
        {
            if (alphabets_counter[item - 'a'] == 0)
                return false;

            alphabets_counter[item - 'a']--;
        }

        return true;
    }
}
