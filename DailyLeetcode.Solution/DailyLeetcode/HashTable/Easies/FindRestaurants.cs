namespace DailyLeetcode.HashTable.Easies;
internal class FindRestaurants
{
    public static string[] FindRestaurant(string[] list1, string[] list2)
    {
        var dict = new SortedDictionary<int, List<string>>();
        for (int i = 0; i < list1.Length; i++)
        {
            for (int j = 0; j < list2.Length; j++)
            {
                if (list1[i] == list2[j])
                {
                    if (!dict.ContainsKey(j + i))
                        dict.Add(j + i, new List<string> { list1[i] });
                    else
                        dict[i + j].Add(list1[i]);
                    break;
                }
            }
        }
        return dict.First().Value.ToArray();
    }
}
