using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class TwoStrings
    {
        public static string twoStrings(string s1, string s2)
        {
            string s1Sorted = new string(s1.ToCharArray().Distinct().ToArray());
            string s2Sorted = new string(s2.ToCharArray().Distinct().ToArray());
            for (int i = 0; i < Math.Min(s1Sorted.Length, s2Sorted.Length); i++)
            {
                if (s1Sorted.IndexOf(s2Sorted[i]) > -1)
                    return "YES";
            }
            return "NO";
        }

    }
}
