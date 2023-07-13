namespace DailyLeetcode.Arrays.Easies;
public sealed class Intersections
{
    public static IList<int> Intersection(int[][] nums)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                if (!dict.ContainsKey(nums[i][j]))
                    dict.Add(nums[i][j], 1);
                else
                    dict[nums[i][j]]++;
            }
        }

        var result = new List<int>();
        foreach (var item in dict)
        {
            if (item.Value == nums.Length)
                result.Add(item.Key);
        }

        return result.OrderBy(x => x).ToList();
    }
}
