namespace DailyLeetcode.Maths.Easies
{
    public class _171_ExcelSheetColumnNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int res = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                int value = char.ToUpper(columnTitle[i]) - 'A' + 1;
                res = res * 26 + value;
            }

            return res;
        }
    }
}
