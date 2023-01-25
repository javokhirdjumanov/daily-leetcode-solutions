namespace DailyLeetcode.HashTable.Easies;
public class DestCity
{
    public static string DestCitys(IList<IList<string>> paths)
    {
        var set = new HashSet<string>();

        foreach (var item in paths)
            set.Add(item[0]);

        foreach (var item in paths)
        {
            if (!set.Contains(item[1]))
                return item[1];
        }

        return "";
    }
}
