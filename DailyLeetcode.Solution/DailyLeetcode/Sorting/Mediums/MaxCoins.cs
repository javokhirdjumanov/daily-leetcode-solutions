namespace DailyLeetcode.Sorting.Mediums;
public sealed class MaxCoins
{
    public static int MaxCoinss(int[] piles)
    {
        int myAllCount = 0;
        int left = 0, right = piles.Length - 2;

        Array.Sort(piles);
        while (left < right)
        {
            myAllCount += piles[right];
            left++;
            right -= 2;
        }

        return myAllCount;
    }
}
