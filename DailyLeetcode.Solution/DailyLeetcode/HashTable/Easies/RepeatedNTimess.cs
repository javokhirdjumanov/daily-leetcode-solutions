namespace DailyLeetcode.HashTable.Easies;
internal class RepeatedNTimess
{
    public static int RepeatedNTimes(int[] nums)
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
            if (item.Value == nums.Length / 2)
                return item.Key;
        }

        return 0;
    }
}
