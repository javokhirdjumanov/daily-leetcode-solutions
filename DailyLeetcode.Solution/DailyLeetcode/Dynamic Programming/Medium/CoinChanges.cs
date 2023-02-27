namespace DailyLeetcode.Dynamic_Programming.Medium;
internal class CoinChanges
{
    public static int CoinChange(int[] coins, int amount)
    {
        HashSet<int> set = new HashSet<int>(coins);
        int[] arr = new int[amount + 1];

        for (int i = 1; i <= amount; i++)
        {
            arr[i] = amount + 1;
            if (set.Contains(i))
            {
                arr[i] = 1;
                continue;
            }

            for (int j = 0; j < coins.Length; j++)
            {
                if (coins[j] <= i)
                    arr[i] = Math.Min(arr[i], 1 + arr[i - coins[j]]);
            }
        }
        return arr[amount] > amount ? -1 : arr[amount];
    }
}
