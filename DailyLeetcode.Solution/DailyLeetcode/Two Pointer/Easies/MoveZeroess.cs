namespace DailyLeetcode.Two_Pointer.Easies
{
    internal class MoveZeroess
    {
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length != 1)
            {
                int left = 0, right = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        left = i; right = left + 1;
                        break;
                    }
                }
                while (right < nums.Length)
                {
                    if (nums[left] == 0 && nums[right] != 0)
                    {
                        int temp = nums[right];
                        nums[right] = nums[left];
                        nums[left] = temp;

                        left++;
                    }
                    right++;
                }
            }
        }
    }
}
