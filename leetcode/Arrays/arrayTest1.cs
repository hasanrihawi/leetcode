using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Arrays
{
    public class arrayTest1
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0 || A.Length == 1)
                return 0;
            int minStepsRequired = int.MaxValue;
            int max = A.Max();
            int min = A.Min();
            for (int j = max; j >= min; j--)
            {
                int currentStepsRequired = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    currentStepsRequired += Math.Abs(A[i] - j);
                }
                if (currentStepsRequired < minStepsRequired)
                    minStepsRequired = currentStepsRequired;
            }
            return minStepsRequired;
        }
    }
}
