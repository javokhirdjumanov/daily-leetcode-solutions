namespace DailyLeetcode.Strings.Mediums;
public sealed class PartitionString
{
    private static int PartitionStrings(string s)
    {
        var list = new List<string>();
        var set = new HashSet<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (set.Contains(s[i].ToString()))
            {
                list.Add(String.Join("", set.ToArray()));

                set = new HashSet<string>();
            }

            set.Add(s[i].ToString());

            if (i == s.Length - 1)
            {
                list.Add(String.Join("", set.ToArray()));
            }
        }

        return list.Count;
    }
}
