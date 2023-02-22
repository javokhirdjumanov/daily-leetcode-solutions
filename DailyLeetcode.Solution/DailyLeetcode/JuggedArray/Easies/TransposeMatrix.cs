namespace DailyLeetcode.JuggedArray.Easies;
internal class TransposeMatrix
{
    public int[][] Transpose(int[][] matrix)
    {
        int[][] result = new int[matrix[0].Length][];

        for (int j = 0; j < matrix[0].Length; j++)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (result[j] == null)
                    result[j] = new int[matrix.Length];

                result[j][i] = matrix[i][j];
            }
        }

        return result;
    }
}
