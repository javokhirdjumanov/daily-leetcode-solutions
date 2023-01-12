using System.Text;

namespace DailyLeetcode.Stacks.MakeGood;
public class MakeGood
{
    public static string MakeGoodss(string s)
    {
        var sb = new StringBuilder();
        var stack = new Stack<string>();

        for (int i = 0; i < s.Length; i++)
        {
            string temp = s[i].ToString();
            bool islower = char.IsLower(s[i]);

            if (stack.Count > 0)
            {
                if (stack.Peek() == char.ToLower(s[i]).ToString() && !islower)
                {
                    stack.Pop();
                }
                else if (stack.Peek() == char.ToUpper(s[i]).ToString() && islower)
                {
                    stack.Pop();
                }
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
