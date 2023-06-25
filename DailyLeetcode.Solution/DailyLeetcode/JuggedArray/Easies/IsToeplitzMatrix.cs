namespace DailyLeetcode.JuggedArray.Easies;
internal class IsToeplitzMatrix
{
    public static bool IsToeplitzMatrixs(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length - 1; i++)
        {
            int ii = i + 1;
            for (int j = 0; j < matrix[0].Length - 1; j++)
            {
                int jj = j + 1;

                if (matrix[i][j] != matrix[ii][jj])
                    return false;
            }
        }

        return true;
    }
}