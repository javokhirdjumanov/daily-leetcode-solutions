namespace DailyLeetcode.Stacks.Mediums;
public sealed class CalPoints
{
    public static int CalPointss(string[] operations)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "C")
                stack.Pop();

            else if (operations[i] == "D")
                stack.Push(stack.Peek() * 2);

            else if (operations[i] == "+")
            {
                int temp = stack.Pop();
                int multiplication = stack.Peek() + temp;

                stack.Push(temp);
                stack.Push(multiplication);
            }
            else
                stack.Push(int.Parse(operations[i]));
        }

        return ResultSumma(stack);
    }
    private static int ResultSumma(Stack<int> stack)
    {
        int summa = 0;

        while (stack.Count > 0)
            summa += stack.Pop();

        return summa;
    }
}
