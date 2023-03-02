namespace DailyLeetcode.Two_Pointer.Mediums;
internal class StringCompress
{
    public static int Compress(char[] chars)
    {
        if (chars.Length == 1) return 1;
        int left = 0, right = 1, index = left + 1;
        while (right < chars.Length)
        {
            if (chars[left] == chars[right]) right++;
            else
            {
                chars[index - 1] = chars[left];
                if (right - left != 1) UpdateCharArray(ref chars, ref left, ref index, ref right);

                left = right; right = left + 1; index++;
            }
        }
        chars[index - 1] = chars[left];
        if (right - left != 1) UpdateCharArray(ref chars, ref left, ref index, ref right);

        return index;
    }
    public static void UpdateCharArray(ref char[] chars, ref int left, ref int index, ref int right)
    {
        string different = (right - left).ToString();
        for (int i = 0; i < different.Length; i++)
        {
            chars[index] = char.Parse((different[i]).ToString()); index++;
        }
    }
}
