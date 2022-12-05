using System.Collections.Generic;

namespace DailyLeetcode.Arrays.UniqueOccurrences;

public class UniqueOccurrences
{
    public static bool UniqueOccurrence(int[] arr)
    {
        HashSet<int> hashSet = new HashSet<int>();
        
        foreach (var item in ForDictionary(arr))
        {
            if (!hashSet.Contains(item.Value))
                hashSet.Add(item.Value);
            else
                return false;
        }

        return true;
    }
    private static Dictionary<int, int> ForDictionary(int[] arr)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int iterator = 0; iterator < arr.Length; iterator++)
        {
            if (dictionary.ContainsKey(arr[iterator]))
                dictionary[arr[iterator]]++;
            else
                dictionary.Add(arr[iterator], 1);
        }

        return dictionary;
    }
}
