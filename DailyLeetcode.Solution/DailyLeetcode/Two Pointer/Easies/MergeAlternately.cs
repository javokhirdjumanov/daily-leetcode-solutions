using System.Text;

namespace DailyLeetcode.Two_Pointer.MergeAlternately;
public sealed class MergeAlternately
{
    public static string MergeAlternatelys(string word1, string word2)
    {
        var sb = new StringBuilder();

        int length_1 = word1.Length, length_2 = word2.Length;
        int index1 = 0, index2 = 0;

        while (length_1 > 0 || length_2 > 0)
        {
            if (length_1 > 0)
            {
                sb.Append(word1[index1++]);
                length_1--;
            }
            if (length_2 > 0)
            {
                sb.Append(word2[index2++]);
                length_2--;
            }
        }

        return sb.ToString();
    }
}
