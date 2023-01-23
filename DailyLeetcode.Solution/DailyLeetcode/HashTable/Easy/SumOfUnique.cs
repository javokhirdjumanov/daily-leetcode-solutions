namespace DailyLeetcode.HashTable.Easy;
public class SumOfUnique
{
    public static int SumOfUniques(int[] nums)
    {
        int summa = 0;
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 1);
            }
            else
            {
                dict[nums[i]]++;
            }
        }
        foreach (var item in dict)
        {
            if (item.Value == 1)
            {
                summa += item.Key;
            }
        }

        return summa;
    }
}
