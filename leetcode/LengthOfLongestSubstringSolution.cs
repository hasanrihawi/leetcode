using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {

            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j <= s.Length; j++)
                {
                    if (i == j)
                        res = Math.Max(res, 1);
                    else if (isUniqueString(s, i, j))
                        res = Math.Max(res, j - i);
                }
            }
            return res;
        }

        private bool isUniqueString(string input, int start, int end)
        {
            int[] chars = new int[128];
            for (int i = start; i <= end; i++)
            {
                char c = input[i];
                chars[c]++;
                if (chars[c] > 1) return false;
            }
            return true;

            //string sub = input.Substring(start, end - start);
            //return sub.Distinct().Count() == sub.Length;

            //var set = new HashSet<char>();
            //for (int i = start; i <= end; i++)
            //    if (!set.Add(input[i]))
            //        return true;
            //return false;
        }
    }

}
