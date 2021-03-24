using System;
using System.Numerics;
using System.Text;

namespace leetcode
{
    public class StringToIntegerAtoi
    {
        public int MyAtoi(string s)
        {
            bool signFounded = false;
            bool numberFounded = false;
            int sign = +1;
            StringBuilder number = new StringBuilder();

            foreach (char c in s.ToCharArray())
            {
                if (c == ' ' && !numberFounded && !signFounded)
                    continue;
                if (c == '-' && !signFounded)
                {
                    sign *= -1;
                    signFounded = true;
                }
                else if (c == '+' && !signFounded)
                {
                    sign *= +1;
                    signFounded = true;
                }
                else if (char.IsDigit(c))
                {
                    number.Append(c);
                    signFounded = true;
                    numberFounded = true;
                }
                else
                    break;
            }
            if (number.Length == 0)
                return 0;

            if (Int32.TryParse(number.ToString(), out int result))
            {
                return result * sign;
            }
            else
            {
                if (sign > 0)
                    return Int32.MaxValue;
                else
                    return Int32.MinValue;

            }
        }
    }
}
