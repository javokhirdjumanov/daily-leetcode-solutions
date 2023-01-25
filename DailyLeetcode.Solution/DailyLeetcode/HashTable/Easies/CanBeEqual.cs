namespace DailyLeetcode.HashTable.Easies;
public sealed class CanBeEqual
{
    public static bool CanBeEquals(int[] target, int[] arr)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
                dict.Add(arr[i], 1);
            else
                dict[arr[i]]++;
        }

        for (int i = 0; i < target.Length; i++)
        {
            if (dict.ContainsKey(target[i]))
            {
                if (dict[target[i]] != 0)
                    dict[target[i]]--;
            }
            else
                return false;
        }

        foreach (var item in dict)
        {
            if (item.Value > 0)
                return false;
        }

        return true;
    }
}
