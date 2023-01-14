namespace DailyLeetcode.Arrays;
public class MaxProfits
{
    public static int MaxProfit(int[] prices)
    {
        int minPrice = prices[0], maxPrice = int.MinValue;

        for (int iterator = 0; iterator < prices.Length; iterator++)
        {
            if (prices[iterator] < minPrice)
                minPrice = prices[iterator];

            maxPrice = Math.Max(maxPrice, prices[iterator] - minPrice);
        }

        if (maxPrice > 0)
            return maxPrice;

        return 0;
    }
}
