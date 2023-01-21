namespace DailyLeetcode.Sorting;
public class SmallerNumbersThanCurrent
{
    public int[] SmallerNumbersThanCurrents(int[] nums)
    {
        var array = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int counter = 0;
            int temp = nums[i];

            for (int j = 0; j < nums.Length; j++)
            {
                if (temp > nums[j])
                    counter++;
            }

            array.Add(counter);
        }

        return array.ToArray();
    }
}
