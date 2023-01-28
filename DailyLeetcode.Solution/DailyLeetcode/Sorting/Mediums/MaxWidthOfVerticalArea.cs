namespace DailyLeetcode.Sorting.Mediums;
public sealed class MaxWidthOfVerticalArea
{
    public static int MaxWidthOfVerticalAreas(int[][] points)
    {
        int[] sortedArray = new int[points.Length];

        for (int i = 0; i < points.Length; i++)
            sortedArray[i] = points[i][0];

        Array.Sort(sortedArray);

        return MaxWidthOfVerticalAreaCopy(sortedArray);
    }
    private static int MaxWidthOfVerticalAreaCopy(int[] sortedArray)
    {
        int maximalArea = 0;

        for (int i = 1; i < sortedArray.Length; i++)
        {
            int temp = sortedArray[i] - sortedArray[i - 1];

            maximalArea = Math.Max(maximalArea, temp);
        }

        return maximalArea;
    }
}
