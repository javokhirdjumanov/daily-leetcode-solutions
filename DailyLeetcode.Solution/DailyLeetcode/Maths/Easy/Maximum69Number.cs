using System.Text;
namespace DailyLeetcode.Maths.Easy;
public sealed class Maximum69Number
{
    private static int Maximum69Numbers(int num)
    {
        var sb = new StringBuilder();
        sb.Append(num.ToString());

        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '6')
            {
                sb.Replace(sb[i], '9', i, 1);
                break;
            }
        }

        return int.Parse(sb.ToString());
    }
}
