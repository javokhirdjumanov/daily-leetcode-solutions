namespace DailyLeetcode.HashTable.Easies;
public sealed class DivideArray
{
    public static bool DivideArrays(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], 1);
            else
                dict[nums[i]]++;
        }

        foreach (var item in dict)
        {
            if (item.Value % 2 == 1)
                return false;
        }
        return true;
    }
}
