namespace DailyLeetcode.JuggedArray.LargestLocal;

public class LargestLocal
{
    public static int[][] LargestLocals(int[][] grid)
    {
        int[][] result = new int[grid.Length - 2][];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[grid.Length - 2];
        }

        for (int i = 0; i < grid.Length - 2; i++)
        {
            for (int j = 0; j < grid.Length - 2; j++)
            {
                int max = int.MinValue;
                for (int k = i; k < i + 3; k++)
                {
                    for (int h = j; h < j + 3; h++)
                    {
                        max = Math.Max(max, grid[k][h]);
                    }
                }
                result[i][j] = max;
            }
        }

        return result;
    }
}