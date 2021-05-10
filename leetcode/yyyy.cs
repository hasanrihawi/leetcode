using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class yyyy
    {
        public string solution(string s = "51Pa*0Lp*0e")
        {
            // aP1pL5e
            StringBuilder decryptedString = new StringBuilder();
            Stack<char> digits = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]) && s[i] != '0')
                {
                    digits.Push((s[i]));
                }
                else if (s[i] == '0')
                {
                    var digit = digits.Pop();
                    decryptedString.Append(digit);
                }
                else if (s[i] != '*')
                {
                    if (i < s.Length -2 && (s[i + 1] == '*' || s[i + 2] == '*'))
                        continue;
                    decryptedString.Append(s[i]);
                }
                else if (s[i] == '*')
                {
                    decryptedString.Append(s[i - 1]);
                    decryptedString.Append(s[i - 2]);
                }
                var xx = decryptedString.ToString();
            }
            return decryptedString.ToString();
        }

    }
}
