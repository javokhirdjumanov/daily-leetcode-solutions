namespace DailyLeetcode.HashTable.CountConsistentStrings;
public class CountConsistentStrings
{
    public static int CountConsistentStringss(string allowed, string[] words)
    {
        var set = new HashSet<string>();
        int counter = 0;

        for (int i = 0; i < allowed.Length; i++)
            set.Add(allowed[i].ToString());

        for (int i = 0; i < words.Length; i++)
        {
            bool exist = true;
            for (int j = 0; j < words[i].Length; j++)
            {
                if (!set.Contains(words[i][j].ToString()))
                {
                    exist = false;
                    break;
                }
            }

            if (exist)
                counter++;
        }

        return counter;
    }
}
