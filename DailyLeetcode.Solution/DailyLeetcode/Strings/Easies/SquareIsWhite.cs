namespace DailyLeetcode.Strings.Easies;
public sealed class SquareIsWhite
{
    public static bool SquareIsWhites(string coordinates)
    {
        var dict = new Dictionary<string, int>()
        {
            {"a", 1 }, {"b", 2}, {"c", 3}, {"d", 4}, {"e", 5}, {"f", 6},{"g", 7}, { "h", 8}
        };

        foreach (var item in dict)
        {
            if (coordinates[0].ToString() == item.Key)
            {
                int temp = int.Parse(coordinates[1].ToString());

                if ((item.Value + temp) % 2 == 1)
                {
                    return true;
                }
            }
        }

        return false;
    }
}