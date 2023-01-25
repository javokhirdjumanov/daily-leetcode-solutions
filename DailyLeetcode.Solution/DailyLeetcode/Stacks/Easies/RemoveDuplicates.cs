using System.Text;

namespace DailyLeetcode.Stacks.Easies;
public class RemoveDuplicates
{
    public static string RemoveDuplicatess(string s)
    {
        var sb = new StringBuilder();
        var stack = new Stack<string>();

        for (int i = 0; i < s.Length; i++)
        {
            string temp = s[i].ToString();

            if (stack.Count > 0)
            {
                if (stack.Peek() == temp)
                    stack.Pop();
                else
                    stack.Push(temp);
            }
            else
                stack.Push(temp);
        }

        while (stack.Count > 0)
            sb.Insert(0, stack.Pop());

        return sb.ToString();
    }
}
