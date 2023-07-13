namespace DailyLeetcode.Arrays.Easies;
public sealed class Intersection
{
    public static int[] Intersections(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>(nums1);

        foreach (var item in set)
        {
            if (!nums2.Contains<int>(item))
                set.Remove(item);
        }

        return set.ToArray();
    }
}
