namespace DailyLeetcode.Sorting.Mediums
{
    internal class ArrangeWordss
    {
        public static string ArrangeWords(string text)
        {
            var sortDict = new SortedDictionary<int, List<string>>();

            var words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!sortDict.ContainsKey(words[i].Length))
                    sortDict.Add(words[i].Length, new List<string>() { words[i].ToLower() });
                else
                    sortDict[words[i].Length].Add(words[i].ToLower());
            }

            var result = string.Join(" ", sortDict.Values.SelectMany(list => list));

            return result.Substring(0, 1).ToUpper() + result.Substring(1); ;
        }
    }
}
