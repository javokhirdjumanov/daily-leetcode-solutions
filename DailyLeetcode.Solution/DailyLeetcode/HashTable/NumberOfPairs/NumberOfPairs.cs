namespace DailyLeetcode.HashTable.NumberOfPairs;
public class NumberOfPairs
{
    public static int[] NumberOfPairss(int[] nums)
    {
        var result = new int[2];
        var dict = new Dictionary<int, int>();

        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 1);
            }
            else
            {
                result[0] = counter + 1;
                dict.Remove(nums[i]);
                counter++;
            }
        }
        result[1] = dict.Count;

        return result;
    }
}
