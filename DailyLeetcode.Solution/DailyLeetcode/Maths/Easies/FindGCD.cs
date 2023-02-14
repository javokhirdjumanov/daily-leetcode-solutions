namespace DailyLeetcode.Maths.Easies;
public class FindGCD
{
    public static int FindGCDs(int[] nums)
    {
        var maximalElement = nums.Max();
        var minimalElement = nums.Min();

        int cycle = minimalElement;
        while (cycle > 0)
        {
            if (maximalElement % cycle == 0 && minimalElement % cycle == 0)
                return cycle;

            cycle--;
        }

        return 1;
    }
}
