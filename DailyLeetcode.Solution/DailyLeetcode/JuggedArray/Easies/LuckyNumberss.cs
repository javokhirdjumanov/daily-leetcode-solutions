namespace DailyLeetcode.JuggedArray.Easies;
internal class LuckyNumberss
{
    public static IList<int> LuckyNumbers(int[][] matrix)
    {
        var list = new List<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            bool isHas = false;
            int minimal = matrix[i].Min();

            int column = FindTheColumn(minimal, matrix, i);

            for (int j = 0; j < matrix.Length; j++)
            {
                if (matrix[j][column] > minimal)
                {
                    isHas = true; break;
                }
            }
            if (!isHas)
                list.Add(minimal);
        }
        return list;
    }
    public static int FindTheColumn(int minimal, int[][] matrix, int i)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            if (minimal == matrix[i][j])
                return j;
        }
        return 0;
    }
}
