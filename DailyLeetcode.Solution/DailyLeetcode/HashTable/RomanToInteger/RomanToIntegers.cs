namespace DailyLeetcode.HashTable.RomanToInteger;
public class RomanToIntegers
{
    public class Program
    {
        public static int RomanToInteger(string satr)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                    {"I", 1},
                    {"IV", 4},
                    {"V", 5},
                    {"IX", 9},
                    {"X", 10},
                    {"XL", 40},
                    {"L", 50},
                    {"XC", 90},
                    {"C", 100},
                    {"CD", 400},
                    {"D", 500},
                    {"CM", 900},
                    {"M", 1000},
            };
            string duality = "";
            string unity = "";
            int summa = 0;

            if (satr.Length == 1)
            {
                if (dictionary.ContainsKey(satr[satr.Length - 1].ToString()))
                    summa += dictionary[satr[satr.Length - 1].ToString()];

                return summa;
            }

            for (int i = 0; i < satr.Length - 1; i++)
            {
                duality = satr[i].ToString() + satr[i + 1].ToString();
                unity = satr[i].ToString();

                if (dictionary.ContainsKey(duality))
                {
                    summa += dictionary[duality];
                    i++;
                }
                else if (dictionary.ContainsKey(unity))
                    summa += dictionary[unity];
 
                if (i == satr.Length - 2)
                    summa += dictionary[satr[i + 1].ToString()];
            }

            return summa;
        }
    }
}
