namespace DailyLeetcode.Maths.PivotInteger;
public class PivotInteger
{
    public static int PivotIntegers(int number)
    {
        int tempSumma = 0, totalSumma = 0;

        for (int iterator = 1; iterator <= number; iterator++)
            totalSumma += iterator;

        for (int iterator = 0; iterator <= number; iterator++)
        {
            if (tempSumma + iterator == totalSumma - tempSumma)
                return iterator;

            tempSumma += iterator;
        }

        return -1;
    }
}
