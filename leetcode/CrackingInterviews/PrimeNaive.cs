using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.CrackingInterviews
{
    class PrimeNaive
    {
        bool primeNaive(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
