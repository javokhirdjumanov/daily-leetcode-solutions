namespace DailyLeetcode.Arrays.Mediums;
public sealed class MaxArea
{
    public int MaxAreas(int[] height)
    {
        int max = 0, left = 0, right = height.Length - 1;

        while (right > 0)
        {
            int temp = Math.Min(height[left], height[right]);

            max = Math.Max(((right - left) * temp), max);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return max;
    }
}
