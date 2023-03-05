using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Strings.Mediums;
internal class IsIsomorphics
{
    public static bool IsIsomorphic(string s, string t)
    {
        var dict = new Dictionary<string, string>();

        var set = new HashSet<string>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i].ToString()))
            {
                if (!set.Contains(t[i].ToString()))
                    set.Add(t[i].ToString());
                else return false;

                dict.Add(s[i].ToString(), t[i].ToString());
            }
            else
            {
                if (t[i].ToString() != dict[s[i].ToString()]) 
                    return false;
            }
        }

        return true;
    }
}