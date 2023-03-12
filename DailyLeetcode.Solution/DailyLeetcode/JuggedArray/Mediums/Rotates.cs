namespace DailyLeetcode.JuggedArray.Mediums;
internal class Rotates
{
    public static void Rotate(int[][] matrix)
    {
        var result = new int[matrix.Length][];

        for (int i = 0; i < matrix[0].Length; i++)
        {
            for (int j = 0, index = matrix.Length - 1; j < matrix.Length && index >= 0; j++, index--)
            {
                if (result[i] == null)
                    result[i] = new int[matrix.Length];

                result[i][index] = matrix[j][i];
            }
        }

        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[i].Length; j++)
                matrix[i][j] = result[i][j];
    }
}
// Link: https://leetcode.com/problems/rotate-image/
