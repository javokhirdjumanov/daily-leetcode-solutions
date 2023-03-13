namespace DailyLeetcode.Arrays.Easies;
internal class FindTheDistanceValues
{
    public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        int counter = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            counter++;
            for (int j = 0; j < arr2.Length; j++)
            {
                if (Math.Abs(arr1[i] - arr2[j]) <= d)
                {
                    counter--; break;
                }
            }
        }

        return counter;
    }
}
// Link: https://leetcode.com/submissions/detail/914548665/
