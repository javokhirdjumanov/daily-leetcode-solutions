namespace DailyLeetcode.Bit_Manipulation.Easies;
internal class FindComplements
{
    public static int FindComplement(int num)
    {
        string replaceBits = new string(Convert
                        .ToString(num, 2)
                        .Select(c => c == '0' ? '1' : '0')
                        .ToArray());

        int length = replaceBits.Length - 1, result = 0;

        for (int i = 0; i < replaceBits.Length; i++)
            result += (int)((replaceBits[i] - 48) * Math.Pow(2, length--));

        return result;
    }
}
