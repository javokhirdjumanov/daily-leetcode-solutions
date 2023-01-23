namespace DailyLeetcode.HashTable.Medium;
public class TopKFrequent
{
    public static int[] TopKFrequents(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], 1);
            else
                dict[nums[i]]++;
        }

        var array = ArrayWithList(nums, dict);

        return Result(array, k);
    }
    private static List<int>[] ArrayWithList(int[] nums, Dictionary<int, int> dict)
    {
        List<int>[] array = new List<int>[nums.Length + 1];

        foreach (var item in dict)
        {
            if (array[item.Value] == null)
                array[item.Value] = new List<int>();

            array[item.Value].Add(item.Key);
        }

        return array;
    }
    private static int[] Result(List<int>[] arr, int k)
    {
        List<int> result = new List<int>();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != null)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (k < 1)
                        break;

                    result.Add(arr[i][j]);
                    k--;
                }
            }
        }

        return result.ToArray();
    }
}
