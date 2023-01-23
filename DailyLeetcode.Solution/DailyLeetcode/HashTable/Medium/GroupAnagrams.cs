namespace DailyLeetcode.HashTable.Medium;
public class GroupAnagrams
{
    public static IList<IList<string>> GroupAnagramss(string[] strs)
    {
        Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string temp = string.Concat(strs[i].OrderBy(x => x));

            if (!dic.ContainsKey(temp))
                dic.Add(temp, new List<string>() { strs[i] });
            else
                dic[temp].Add(strs[i]);
        }

        return
            dic.Values.ToList();
    }
}
