namespace DailyLeetcode.HashTable.Easies;
public sealed class RepeatedCharacter
{
    public static char RepeatedCharacters(string s)
    {
        var set = new HashSet<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!set.Contains(s[i].ToString()))
                set.Add(s[i].ToString());
            else
                return s[i];
        }

        return ' ';
    }
}
