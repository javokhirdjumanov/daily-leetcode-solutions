namespace DailyLeetcode.Maths.Mediums;
internal class TwoSums
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    numbers[0] = i + 1; numbers[1] = j + 1;
                    Array.Resize(ref numbers, 2);
                    return numbers;
                }
            }
        }
        return null;
    }
}
