namespace DailyLeetcode.HashTable.Mediums;
public sealed class KthDistinct
{
    public static string KthDistincts(string[] arr, int k)
    {
        var list = new List<string>();
        var dict = new Dictionary<string, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i].ToString()))
                dict.Add(arr[i].ToString(), 1);
            else
                dict[arr[i].ToString()]++;
        }

        foreach (var item in dict)
        {
            if (item.Value == 1)
                list.Add(item.Key);
        }

        if (list.Count >= k)
            return list[k - 1];

        return "";
    }
}
