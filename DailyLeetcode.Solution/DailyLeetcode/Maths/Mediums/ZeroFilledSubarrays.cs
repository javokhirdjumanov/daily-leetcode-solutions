namespace DailyLeetcode.Maths.Mediums;
internal class ZeroFilledSubarrays
{
    public static long ZeroFilledSubarray(int[] nums)
    {
        long result = 0; int zCnt = 0;
        foreach (int num in nums)
        {
            if (num == 0)
                zCnt++;
            else
                zCnt = 0;

            result += zCnt;
        }
        return result;
    }
}
