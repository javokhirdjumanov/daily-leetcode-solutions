namespace DailyLeetcode.Two_Pointer.SumOddLengthSubarrays;

public sealed class SumOddLengthSubarrays
{
    public static int SumOddLengthSubarrayss(int[] arr)
    {
        int summa = 0, left = 0, right = 1;
        while (left < arr.Length && right < arr.Length)
        {
            if ((right - left) % 2 == 0)
            {
                for (int i = left; i <= right; i++)
                    summa += arr[i];
            }
            if (right == arr.Length - 1)
            {
                left++;
                right = left + 1;
            }
            else
                right++;
        }
        for (int i = 0; i < arr.Length; i++)
            summa += arr[i];

        return summa;
    }
}
