using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class LengthOfLongestSubstringSolution2
    {
        public int lengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int ans = 0;
            Dictionary<char, int> map = new Dictionary<char, int>(); 
            int i = 0;
            for (int j = 0; j < n; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    i = Math.Max(map[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);

                // this line will override the value for the same key
                map[s[j]] = j + 1;

                //this line will throw exception on existance key
                //map.Add(s[j], j + 1);
            }
            return ans;
        }
    }

}
