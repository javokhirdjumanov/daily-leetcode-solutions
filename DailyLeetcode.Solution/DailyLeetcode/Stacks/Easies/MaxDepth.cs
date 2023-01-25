namespace DailyLeetcode.Stacks.Easies;
public class MaxDepth
{
    public static int MaxDepths(string s)
    {
        int counter = 0, result = 0;
        var stack = new Stack<string>();

        for (int i = 0; i < s.Length; i++)
        {
            string temp = s[i].ToString();

            if (temp == "(")
            {
                stack.Push(temp);
                counter++;
            }
            else if (temp == ")")
            {
                stack.Pop();
                result = Math.Max(result, counter);

                counter--;
            }
        }

        return result;
    }
}
