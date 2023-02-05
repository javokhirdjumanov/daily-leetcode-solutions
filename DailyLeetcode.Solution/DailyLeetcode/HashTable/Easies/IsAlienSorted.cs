namespace DailyLeetcode.HashTable.Easies;
public sealed class IsAlienSorted
{
    public static Dictionary<string, int> AlphabetOrder(string order)
    {
        var dict = new Dictionary<string, int>();

        for (int i = 0; i < order.Length; i++)
            dict.Add(order[i].ToString(), i + 1);

        return dict;
    }
    public static bool IsAlienSorteds(string[] words, string order)
    {
        var orderalphabet = AlphabetOrder(order);

        bool result = true, check = false;
        string temp1 = "", temp2 = "";

        for (int i = 1; i < words.Length; i++)
        {
            temp1 = words[i - 1]; temp2 = words[i];
            int min = Math.Min(temp1.Length, temp2.Length);

            for (int j = 0; j < min; j++)
            {
                if (orderalphabet[temp1[j].ToString()] < orderalphabet[temp2[j].ToString()])
                {
                    result = true;
                    check = false;
                    break;
                }
                else if (orderalphabet[temp1[j].ToString()] == orderalphabet[temp2[j].ToString()])
                {
                    check = true;
                    continue;
                }
                else
                    return false;
            }
        }
        if (check && temp1.Length > temp2.Length)
            return false;

        return result;
    }
}
