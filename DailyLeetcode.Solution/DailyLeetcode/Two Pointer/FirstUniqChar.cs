namespace DailyLeetcode.Two_Pointer.FirstUniqChar;
public sealed class FirstUniqChar
{
    public static int FirstUniqChars(string @string)
    {
        var lettersCount = new int[26];

        for (int i = 0; i < @string.Length; i++)
            lettersCount[@string[i] - 'a']++;

        for (int i = 0; i < @string.Length; i++)
        {
            if (lettersCount[@string[i] - 'a'] == 1)
                return i;
        }

        return -1;
    }
}
