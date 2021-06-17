using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Arrays
{
    public class arrayManipulation
    {
        public static long ArrayManipulation(int n, List<List<int>> queries)
        {
            int[] results = new int[n];
            foreach (var q in queries)
            {
                int a = q[0];
                int b = q[1];
                int k = q[2];
                results[a - 1] = results[a - 1] + k;
                results[b] = results[b] - k;
            }
            for (int i = 1; i < n; i++)
            {
                results[i] = results[i] + results[i - 1];
            }
            return results.Max();
        }
    }
}
