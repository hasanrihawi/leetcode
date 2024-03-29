﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Arrays
{
    public class rotateLeftArray
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var groupedList = A.GroupBy(e => e).Select(group => new
            {
                value = group.Key,
                count = group.Count()
            });
            return groupedList.Count() > 0 ? groupedList.First(gv => gv.count == 1).value : 0;
    }
    }
}
