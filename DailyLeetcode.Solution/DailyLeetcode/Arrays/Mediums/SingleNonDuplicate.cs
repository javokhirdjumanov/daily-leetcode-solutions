namespace DailyLeetcode.Arrays.Mediums;
internal class SingleNonDuplicate
{
    public static int SingleNonDuplicates(int[] nums)
    {
        // Two solution

        //for (int i = 1; i < nums.Length; i++)
        //{
        //    if (nums[i - 1] == nums[i])
        //        i++;
        //    else
        //        return nums[i - 1];

        //    if (i == nums.Length - 1)
        //        return nums[i];
        //}
        //return nums[0];



        // One solution

        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i]))
                set.Remove(nums[i]);
            else
                set.Add(nums[i]);
        }
        return set.ToArray()[0];
    }
}
