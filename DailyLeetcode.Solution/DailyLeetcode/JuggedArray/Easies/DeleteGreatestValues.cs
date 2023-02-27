namespace DailyLeetcode.JuggedArray.Easies;
internal class DeleteGreatestValues
{
    public static int DeleteGreatestValue(int[][] grid)
    {
        grid = grid.Select(subArray => subArray
                   .OrderBy(num => num).ToArray()).ToArray();

        int maximal = 0, result = 0;
        for (int j = 0; j < grid[0].Length; j++)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                maximal = Math.Max(maximal, grid[i][j]);
            }
            result += maximal;
        }

        return result;
    }
}
