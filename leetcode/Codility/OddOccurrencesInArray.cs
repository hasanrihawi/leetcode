using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Arrays
{
    public class OddOccurrencesInArray
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var grouped = A.GroupBy(e => e).Select(group => new
            {
                value = group.Key,
                count = group.Count()
            });
            return grouped.First(gv => gv.count % 2 == 1).value;
        }
    }
}
