namespace DailyLeetcode.Sorting.Easies;
public sealed class MinMovesToSeat
{
    private int MinMovesToSeats(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);

        int counter = 0;

        for (int i = 0; i < seats.Length; i++)
        {
            int temp = Math.Abs(seats[i] - students[i]);

            counter += temp;
        }

        return counter;
    }
}
