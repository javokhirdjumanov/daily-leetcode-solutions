namespace DailyLeetcode.Bit_Manipulation.Mediums;
internal class SortByBitss
{
    public static int[] SortByBits(int[] arr)
    {
        var dict = new SortedDictionary<int, List<int>>();

        for (int i = 0; i < arr.Length; i++)
        {
            string @bytes = Convert.ToString(arr[i], 2);

            int sumOfDigitsOfNumber = @bytes.ToString()
                .Select(digit => int.Parse(digit.ToString()))
                .ToArray().Sum();

            if (!dict.ContainsKey(sumOfDigitsOfNumber))
                dict[sumOfDigitsOfNumber] = new List<int>();

            dict[sumOfDigitsOfNumber].Add(arr[i]);
        }

        return dict.Values
            .SelectMany(x => x.OrderBy(c => c)).ToArray();
    }
}
