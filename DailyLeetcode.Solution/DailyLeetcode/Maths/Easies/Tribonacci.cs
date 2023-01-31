namespace DailyLeetcode.Maths.Easies;
public sealed class Tribonacci
{
    public static int Tribonaccies(int n)
    {
        int[] arr = new int[38];

        arr[0] = 0;
        arr[1] = 1;
        arr[2] = 1;

        for (int i = 3; i < 38; i++)
        {
            int temp = arr[i - 1] + arr[i - 2] + arr[i - 3];
            arr[i] = temp;
        }

        return arr[n];
    }
}
