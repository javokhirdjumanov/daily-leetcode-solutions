namespace DailyLeetcode.Sorting.Mediums
{
    internal class FindErrorNumss
    {
        public static int[] FindErrorNums(int[] nums)
        {
            var arr = ArrayWithUniqueElement(nums);
            int duplicate = nums.GroupBy(x => x).SingleOrDefault(g => g.Count() > 1).Key;

            List<int> result = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    result.Add(duplicate); result.Add(i + 1);
                    break;
                }
            }
            return result.ToArray();
        }
        public static int[] ArrayWithUniqueElement(int[] nums)
        {
            var arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                arr[nums[i] - 1] = nums[i];

            return arr;
        }
    }
}
