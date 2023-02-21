namespace DailyLeetcode.JuggedArray.Easies;
internal class DiagonalSum
{
    public static int DiagonalSumma(int[][] mat)
    {
        int summa = 0, temp = mat[0].Length - 1;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (i == j)
                {
                    summa += mat[i][j];
                    summa += mat[i][temp--];
                }
            }
        }
        if (mat.Length % 2 == 1)
            summa -= mat[mat.Length / 2][mat.Length / 2];

        return summa;
    }
}
