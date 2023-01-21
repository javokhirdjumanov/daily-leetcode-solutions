namespace DailyLeetcode.Sorting;
public sealed class HeightChecker
{
    private int HeightCheckers(int[] heights)
    {
        int count = 0;

        var cutomArray = CreateCopyOfHeightArray(heights);

        Array.Sort(heights);

        for (int iterator = 0; iterator < heights.Length; iterator++)
        {
            if (heights[iterator] != cutomArray[iterator])
                count++;
        }

        return count;
    }
    private int[] CreateCopyOfHeightArray(int[] heights)
    {
        int[] shadowOfHeight = new int[heights.Length];

        for (int iterator = 0; iterator < heights.Length; iterator++)
            shadowOfHeight[iterator] = heights[iterator];

        return shadowOfHeight;
    }
}
