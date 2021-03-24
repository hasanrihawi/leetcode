using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x = x / 10;

                if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && pop > 7)) return 0;
                if (res < int.MinValue / 10 || (res == int.MinValue / 10 && pop < -8)) return 0;

                res = (res * 10) + pop;
            }
            return res;
        }
    }

}
