using System.Text;

namespace DailyLeetcode.Strings.UniqueMorseRepresentations;
public class UniqueMorseRepresentations
{
    public static int UniqueMorseRepresentationss(string[] words)
    {
        var result = new HashSet<string>();
        var sb = new StringBuilder();
        
        var dict = new Dictionary<char, string>()
        {
            {'a', ".-" }, {'b', "-..."}, {'c',"-.-."},{'d', "-.."},
            {'e',"."}, {'f',"..-." },{'g', "--." }, {'h', "...."}, 
            {'i',".."},{'j', ".---"},{'k',"-.-"}, {'l',".-.." },
            {'m', "--" }, {'n', "-."}, {'o',"---"},{'p', ".--."},
            {'q',"--.-"}, {'r',".-." },{'s', "..." }, {'t',"-"}, 
            {'u',"..-"},{'v', "...-"},{'w',".--"}, {'x',"-..-" },
            {'y', "-.--" }, {'z', "--.."}
        };

        for (int i = 0; i < words.Length; i++)
        {
            sb.Clear();

            for (int j = 0; j < words[i].Length; j++)
                sb.Append(dict[words[i][j]]);

            result.Add(sb.ToString());
        }

        return result.Count;
    }
}
