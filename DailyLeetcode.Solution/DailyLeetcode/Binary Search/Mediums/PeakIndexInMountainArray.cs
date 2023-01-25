namespace DailyLeetcode.Binary_Search;
public sealed class PeakIndexInMountainArray
{
    public static int PeakIndexInMountainArrays(int[] arr)
    {
        int index = 0;

        while (index < arr.Length - 1)
        {
            if (arr[index] < arr[index + 1])
                index++;
            else
                return index;
        }

        return 0;
    }
}
