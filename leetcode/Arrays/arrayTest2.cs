using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode.Arrays
{
    public class arrayTest2
    {
        public static int solution(int[] A)
        {
            int start = 0;
            int finish = A.Length;
            int evenPairsCount = 0;
            if (A.Length == 1)
                return 0;
            while (start < finish)
            {
                if (start == 0 && (A[start] + A[A.Length - 1]) % 2 == 0)
                {
                    start++;
                    finish--;
                    evenPairsCount++;
                }
                else if (start + 1 < finish && (A[start] + A[start + 1]) % 2 == 0)
                {
                    start += 2;
                    evenPairsCount++;
                }
                else
                {
                    start++;
                }
            }
            return evenPairsCount;
        }
    }
}
