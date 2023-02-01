namespace DailyLeetcode.Two_Pointer.Mediums;
public sealed class AppendCharacters
{
    public static int AppendCharacterss(string s, string t)
    {
        int indexS = 0, indexT = 0, length = 0;

        while (indexT < t.Length && indexS < s.Length)
        {
            if (s[indexS] == t[indexT])
            {
                length++;

                indexS++; indexT++;
            }
            else
                indexS++;
        }

        return t.Length - length;
    }
}
