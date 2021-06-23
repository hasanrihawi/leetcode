using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            int left = A[0];
            int right = A.Skip(1).Aggregate((c, x) => c += x);
            int minResult = Math.Abs(left - right);
            for (int p = 1; p < A.Length - 1; p++)
            {
                left += A[p];
                right -= A[p];
                int res = Math.Abs(left - right);
                minResult = Math.Min(minResult, res);
            }
            return minResult;
        }

        // slow solution
        public static int solutionslow(int[] A)
        {
            int minResult = int.MaxValue;
            for (int p = 1; p < A.Length; p++)
            {
                int sum1 = A.Take(p).Sum();
                int sum2 = A.Skip(p).Sum();
                int res = Math.Abs(sum1 - sum2);
                minResult = Math.Min(minResult, res);
            }
            return minResult;
        }
    }
}
