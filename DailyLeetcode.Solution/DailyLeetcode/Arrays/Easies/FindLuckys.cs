namespace DailyLeetcode.Arrays.Easies;
internal class FindLuckys
{
    public static int FindLucky(int[] arr)
    {
        int maximalElement = 0;

        Dictionary<int, int> map = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!map.ContainsKey(arr[i]))
                map.Add(arr[i], 1);
            else
                map[arr[i]]++;
        }
        foreach (var item in map)
        {
            if (item.Value == item.Key)
                maximalElement = Math.Max(maximalElement, item.Value);
        }
        return maximalElement;
    }
}
