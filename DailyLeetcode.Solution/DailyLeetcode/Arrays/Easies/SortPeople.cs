namespace DailyLeetcode.Arrays.Easies;
public class SortPeople
{
    public string[] SortPeoples(string[] names, int[] heights)
    {
        var sortedDict = new SortedDictionary<int, string>();

        int heightsIndex = 0, namesIndex = 0;

        while (namesIndex < names.Length)
        {
            sortedDict.Add(heights[heightsIndex++], names[namesIndex++]);
        }

        var result = new List<string>();

        foreach (string val in sortedDict.Values)
            result.Add(val);

        result.Reverse();

        return result.ToArray();
    }
}
