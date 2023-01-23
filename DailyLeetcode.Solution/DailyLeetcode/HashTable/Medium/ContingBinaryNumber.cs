using System.Text;

namespace DailyLeetcode.HashTable.Medium;
public class ContingBinaryNumber
{
    private static string ContingBinaryNumbers(int counter)
    {
        StringBuilder stringBuilder = new StringBuilder();

        Dictionary<int, char> map = new Dictionary<int, char>()
        {
            {10, 'a'},
            {11, 'b'},
            {12, 'c'},
            {13, 'd'},
            {14, 'e'},
            {15, 'f'},
        };

        if (counter == 0)
        {
            Console.WriteLine(0);
            return "";
        }
        else if (counter < 0)
        {
            long nums = (long)Math.Pow(2, 32) + counter;

            while (nums > 0)
            {
                int qoldiq = (int)(nums % 16);

                if (map.ContainsKey(qoldiq))
                    stringBuilder.Insert(0, map[qoldiq]);
                else
                    stringBuilder.Insert(0, qoldiq.ToString());

                nums /= 16;
            }
        }
        else
        {
            while (counter > 0)
            {
                int qoldiq = counter % 16;

                if (map.ContainsKey(qoldiq))
                    stringBuilder.Insert(0, map[qoldiq]);
                else
                    stringBuilder.Insert(0, qoldiq.ToString());

                counter /= 16;
            }
        }

        return stringBuilder.ToString();
    }
}
