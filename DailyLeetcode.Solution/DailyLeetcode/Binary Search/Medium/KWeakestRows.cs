namespace DailyLeetcode.Binary_Search.Medium;
public sealed class KWeakestRows
{
    public static int[] KWeakestRowss(int[][] mat, int k)
    {
        var dictionary = FillTheDictionary(mat);

        var result = FillTheSortedArray(mat);

        return Result(
            result: result, 
            dictionary: dictionary, 
            k: k
            );
    }
    private static Dictionary<int, int> FillTheDictionary(int[][] mat)
    {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (!dictionary.ContainsKey(i))
                    dictionary.Add(i, 0);

                if (mat[i][j] == 1)
                    dictionary[i]++;
            }
        }
        return dictionary;
    }
    private static int[] FillTheSortedArray(int[][] mat)
    {
        var result = new int[FillTheDictionary(mat).Count];

        foreach (var item in FillTheDictionary(mat))
            result[item.Key] = item.Value;

        Array.Sort(result);
        return result;
    }
    private static int[] Result(int[] result, Dictionary<int, int> dictionary, int k)
    {
        for (int i = 0; i < result.Length; i++)
        {
            foreach (var item in dictionary)
            {
                if (result[i] == item.Value)
                {
                    result[i] = item.Key;
                    dictionary.Remove(item.Key);
                    break;
                }
            }
        }
        return result[0..k];
    }
}
