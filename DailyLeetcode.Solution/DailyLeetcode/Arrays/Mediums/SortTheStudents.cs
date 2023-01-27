namespace DailyLeetcode.Arrays.Mediums;
public sealed class SortTheStudents
{
    public static int[][] SortTheStudentss(int[][] score, int k)
    {
        var result = new int[score.Length][];

        var sortedArray = SortedElementInScore(score: score, k: k);
        for (int i = 0; i < sortedArray.Length; i++)
        {
            for (int j = 0; j < score.Length; j++)
            {
                if (sortedArray[i] == score[j][k])
                {
                    result[i] = score[j];
                    break;
                }
            }
        }
        return result;
    }
    private static int[] SortedElementInScore(int[][] score, int k)
    {
        var sortedArray = new int[score.Length];

        for (int i = 0; i < score.Length; i++)
            sortedArray[i] = score[i][k];

        return
            sortedArray.OrderByDescending(c => c).ToArray();
    }
}
