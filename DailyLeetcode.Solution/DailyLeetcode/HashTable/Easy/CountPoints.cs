namespace DailyLeetcode.HashTable.Easy;
public class CountPoints
{
    public static int CountPointss(string rings)
    {
        int counter = 0;
        HashSet<string>[] result = new HashSet<string>[10];

        for (int i = 0; i < rings.Length; i += 2)
        {
            int temp = rings[i + 1] - '0';

            if (result[temp] is null)
                result[temp] = new HashSet<string>();

            result[temp].Add(rings[i].ToString());
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] is not null)
            {
                if (result[i].Count == 3)
                    counter++;
            }
        }

        return counter;
    }
}
