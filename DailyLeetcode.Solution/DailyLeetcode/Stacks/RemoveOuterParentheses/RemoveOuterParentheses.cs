using System.Text;

namespace DailyLeetcode.Stacks.RemoveOuterParentheses;
public class RemoveOuterParentheses
{
    public static string RemoveOuterParenthesess(string s)
    {
        var sb = new StringBuilder();
        var stack = new Stack<string>();

        for (int i = 0; i < s.Length; i++)
        {
            string temp = s[i].ToString();

            if (temp == ")")
            {
                if (stack.Count > 1)
                {
                    sb.Append(temp);
                    stack.Pop();
                }
                else
                    stack.Pop();
            }
            else
            {
                if (stack.Count >= 1)
                    sb.Append(temp);

                stack.Push(temp);
            }
        }
        return sb.ToString();
    }
}
