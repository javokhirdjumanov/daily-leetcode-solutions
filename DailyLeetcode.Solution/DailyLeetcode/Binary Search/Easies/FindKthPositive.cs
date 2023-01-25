namespace DailyLeetcode.Binary_Search.Easies;
public sealed class FindKthPositive
{
    public int FindKthPositives(int[] arr, int k)
    {
        var list = new List<int>();

        var set = FillTheHashSet(arr);

        for (int i = 0; i < 1000 + arr.Length; i++)
        {
            if (!set.Contains(i + 1))
                list.Add(i + 1);
        }
        return list[k - 1];
    }
    private HashSet<int> FillTheHashSet(int[] arr)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
            set.Add(arr[i]);

        return set;
    }
}
