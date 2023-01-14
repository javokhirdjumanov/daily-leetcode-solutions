using System.Text;

namespace DailyLeetcode.Strings;
public class AddString
{
    public static string AddStrings1(string num1, string num2)
    {
        StringBuilder sb = new StringBuilder();
        int iterator = num1.Length - 1, iterator1 = num2.Length - 1, residual = 0;

        OneCondition(iterator, iterator1, residual, num1, num2, sb);

        TwoCondition(iterator, residual, num1, sb);

        ThreeCondition(iterator1, residual, num2, sb);

        return sb.ToString();
    }
    private static void OneCondition(int iterator, int iterator1,
                                    int residual, string num1,
                                    string num2, StringBuilder sb)
    {
        while (iterator >= 0 && iterator1 >= 0)
        {
            int digit1 = num1[iterator] - '0', digit2 = num2[iterator] - '0';

            int SumLeft = digit1 + digit2 + residual;
            residual = 0;

            if (SumLeft > 9)
            {
                SumLeft %= 10;
                residual = 1;
            }
            sb.Insert(0, SumLeft);

            iterator--;
            iterator1--;
        }
    }
    private static void TwoCondition(int iterator, int residual,
                                   string num1, StringBuilder sb)
    {
        while (iterator >= 0)
        {
            int digit = num1[iterator] - '0';
            int SumLeft = digit + residual;

            residual = 0;
            if (SumLeft > 9)
            {
                SumLeft %= 10;
                residual = 1;
            }
            sb.Insert(0, SumLeft);

            iterator--;
        }
    }
    private static void ThreeCondition(int iterator1, int residual,
                                     string num2, StringBuilder sb)
    {
        while (iterator1 >= 0)
        {
            int digit = num2[iterator1] - '0';
            int SumLeft = digit + residual;

            residual = 0;
            if (SumLeft > 9)
            {
                SumLeft %= 10;
                residual = 1;
            }
            sb.Insert(0, SumLeft);

            iterator1--;
        }
        if (residual > 0)
            sb.Insert(0, residual);
    }
}
