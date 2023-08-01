namespace DailyLeetcode.Dynamic_Programming.Easies;
internal class Fibonacci_Number
{
    public int Fib(int n)
    {
        if (n <= 1) return n;

        int[] arr = new int[n + 1];
        arr[1] = 1;
        arr[2] = 1;

        for (int i = 3; i <= n; i++)
            arr[i] = arr[i - 1] + arr[i - 2];

        return arr[n];
    }
}
