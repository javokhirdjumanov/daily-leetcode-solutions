namespace DailyLeetcode.Two_Pointer.FirstPalindrome;
public sealed class FirstPalindrome
{
    public static string FirstPalindromes(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (IsPalindrom(word))
            {
                return word;
            }
        }

        return "";
    }
    private static bool IsPalindrom(string word)
    {
        int left = 0, right = word.Length - 1;

        while (!(left > right))
        {
            if (word[left] != word[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
