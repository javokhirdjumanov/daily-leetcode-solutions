namespace DailyLeetcode.Sorting.Easies;
public sealed class SortArrayByParity
{
    public static int[] SortArrayByParitys(int[] nums)
    {
        var list = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
                list.Insert(0, nums[i]);
            else
                list.Add(nums[i]);
        }

        return list.ToArray();
    }
}
