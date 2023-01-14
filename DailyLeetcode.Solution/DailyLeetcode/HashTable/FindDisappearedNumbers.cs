namespace DailyLeetcode.HashTable;
public sealed class FindDisappearedNumbers
{
    public static IList<int> FindDisappearedNumberss(int[] nums)
    {
        var result = new List<int>();

        var set = new HashSet<int>(nums);

        int param = 1;
        while (param <= nums.Length)
        {
            if (!set.Contains(param))
                result.Add(param);

            param++;
        }

        return result;
    }
}
