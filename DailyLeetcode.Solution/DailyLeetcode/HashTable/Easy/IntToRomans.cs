using System.Text;

namespace DailyLeetcode.HashTable.Easy;
public class IntToRomans
{
    public static string IntToRoman(int num)
    {
        StringBuilder sb = new StringBuilder();

        var map = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "IV", 4},
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900},
            { "M", 1000 }
        };

        while (num > 0)
        {
            string temporary;
            if (num >= 1000) temporary = "M";
            else if (num >= 900) temporary = "CM";
            else if (num >= 500) temporary = "D";
            else if (num >= 400) temporary = "CD";
            else if (num >= 100) temporary = "C";
            else if (num >= 90) temporary = "XC";
            else if (num >= 50) temporary = "L";
            else if (num >= 40) temporary = "XL";
            else if (num >= 10) temporary = "X";
            else if (num >= 9) temporary = "IX";
            else if (num >= 5) temporary = "V";
            else if (num >= 4) temporary = "IV";
            else temporary = "I";

            sb.Append(temporary);
            num -= map[temporary];
        }

        return sb.ToString();
    }
}
