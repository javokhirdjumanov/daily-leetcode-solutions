using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.HashTable.Mediums;
public sealed class DigitCount
{
    public static bool DigitCounts(string num)
    {
        var numberItemsIndexDict = FindNumberOfItemByIndex(num, FindNumberOfItem(num));

        for (int i = 0; i < num.Length; i++)
        {
            if (numberItemsIndexDict.ContainsKey(i))
            {
                if (numberItemsIndexDict[i] != num[i] - 48)
                    return false;
            }
        }

        return true;
    }
    private static Dictionary<int, int> FindNumberOfItem(string num)
    {
        var numberofitemsDict = new Dictionary<int, int>();

        for (int iterator = 0; iterator < num.Length; iterator++)
        {
            if (!numberofitemsDict.ContainsKey(num[iterator] - 48))
                numberofitemsDict.Add(num[iterator] - 48, 1);
            else
                numberofitemsDict[num[iterator] - 48]++;
        }

        return numberofitemsDict;
    }
    private static Dictionary<int, int> FindNumberOfItemByIndex(
        string num, 
        Dictionary<int, int> numberItemsDict
        )
    {
        var numberItemsIndexDict = new Dictionary<int, int>();

        for (int i = 0; i < num.Length; i++)
        {
            if (!numberItemsIndexDict.ContainsKey(i))
            {
                if (numberItemsDict.ContainsKey(i))
                    numberItemsIndexDict.Add(i, numberItemsDict[i]);
                else
                    numberItemsIndexDict.Add(i, 0);
            }
        }

        return numberItemsIndexDict;
    }

}
