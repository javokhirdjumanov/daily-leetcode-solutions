namespace DailyLeetcode.Strings.NumJewelsInStones;
public class NumJewelsInStoness
{
    private static int NumJewelsInStones(string jewels, string stones)
    {
        HashSet<char> set = new HashSet<char>();
        int counter = 0;

        for (int i = 0; i < jewels.Length; i++)
            set.Add(jewels[i]);

        for (int i = 0; i < stones.Length; i++)
        {
            if (set.Contains(stones[i]))
                counter++;
        }

        return counter;
    }
}
