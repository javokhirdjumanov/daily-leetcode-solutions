namespace DailyLeetcode.Strings.Mediums;
internal class TheFirstOccurrenceIndex
{
    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            string temp = haystack.Substring(i, needle.Length);
            if (temp == needle)
                return i;
        }
        return -1;
    }
}
