using System;
using System.Numerics;
using System.Text;

namespace leetcode
{
    public class StringToIntegerAtoi2
    {
        public int MyAtoi(string str)
        {
            int i = 0;
            int sign = 1;
            int result = 0;
            if (str.Length == 0) return 0;

            //Discard whitespaces in the beginning
            while (i < str.Length && str[i] == ' ')
                i++;

            // Check if optional sign if it exists
            if (i < str.Length && (str[i] == '+' || str[i] == '-'))
                sign = (str[i++] == '-') ? -1 : 1;

            // Build the result and check for overflow/underflow condition
            while (i < str.Length && char.IsDigit(str[i]))
            {
                if (
                    result > Int32.MaxValue / 10 
                    ||
                    (result == Int32.MaxValue / 10 && str[i] - '0' > Int32.MaxValue % 10)
                   )
                {
                    return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
                }
                result = result * 10 + (str[i++] - '0');
            }
            return result * sign;
        }
    }
}
