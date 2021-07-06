using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class RegularExpressionMatch
    {
        public bool isMatch(String text, String pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return string.IsNullOrEmpty(text);
            bool first_match = (!string.IsNullOrEmpty(text) &&
                                   (pattern[0] == text[0] || pattern[0] == '.'));

            if (pattern.Length >= 2 && pattern[1] == '*')
            {
                return (isMatch(text, pattern[2..]) ||
                        (first_match && isMatch(text[1..], pattern)));
            }
            else
            {
                return first_match && isMatch(text[1..], pattern[1..]);
            }
        }
    }
}
