namespace DailyLeetcode.HashTable.Easies;
internal class FindRelativeRankss
{
    public static string[] FindRelativeRanks(int[] score)
    {
        var result = new List<string>();

        var map = Rank(score);
        for (int i = 0; i < score.Length; i++)
            result.Add(map[score[i]]);

        return result.ToArray();
    }
    public static Dictionary<int, string> Rank(int[] score)
    {
        var map = new Dictionary<int, string>();
        var mold = new List<string>() { "Gold Medal", "Silver Medal", "Bronze Medal", };

        for (int i = 4; i <= score.Length; i++)
            mold.Add($"{i}");

        score = score.OrderByDescending(x => x).ToArray();

        for (int i = 0; i < score.Length; i++)
            map.Add(score[i], mold[i]);

        return map;
    }
    // Link: https://leetcode.com/problems/relative-ranks/submissions/921236059/
}
