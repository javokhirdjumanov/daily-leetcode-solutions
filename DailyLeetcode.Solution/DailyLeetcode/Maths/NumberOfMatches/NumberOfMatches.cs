namespace DailyLeetcode.Maths.NumberOfMatches;
public class NumberOfMatches
{
    private static int NumberOfMatchess(int number)
    {
        int counter = 0;

        while (number > 1)
        {
            if (number % 2 == 0)
            {
                counter += number / 2;

                number -= number / 2;
            }
            else if (number % 2 == 1)
            {
                counter += (number - 1) / 2;

                number -= (number - 1) / 2;
            }
        }

        return counter;
    }
}
