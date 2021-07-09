using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.CrackingInterviews
{
    class fibonacciExample
    {
        int fibonacci(int n)
        {
            if (n == 0) return 0;
            int a = 0;
            int b = 1;
            for (int i = 2; i < n; i++)
            {
                int C = a + b;
                a = b;
                b = C;
            }
            return a + b;
        }

        int fibonacci2(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            return fibonacci2(i - 1) + fibonacci2(i - 2);
        }
    }
}
