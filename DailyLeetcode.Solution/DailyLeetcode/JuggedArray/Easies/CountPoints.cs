namespace DailyLeetcode.JuggedArray.Easies;
public class CountPoints
{
    private static int[] CountPointss(int[][] points, int[][] queries)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < queries.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < points.Length; j++)
            {
                double temp =
                    Math.Sqrt(Math.Pow(queries[i][0] - points[j][0], 2) + Math.Pow(queries[i][1] - points[j][1], 2));

                if (temp <= queries[i][2])
                    counter++;
            }

            result.Add(counter);
        }

        return result.ToArray();
    }
}