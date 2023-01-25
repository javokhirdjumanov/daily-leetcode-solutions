namespace DailyLeetcode.Arrays.Mediums;
public class PlusOne
{
    private static void Menu()
    {
        int[] digits = { 1, 9 };

        int[] arr = PlusOnes(digits);

        foreach (int digit in arr)
            Console.Write(digit + " ");
    }
    private static int[] PlusOnes(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}
