namespace DailyLeetcode.Maths.Easies;
public sealed class CountOdds
{
    public int CountOddss(int low, int high)
        => (high % 2 == 0 && low % 2 == 0) ? (high - low) / 2 : (high - low) / 2 + 1;

}
