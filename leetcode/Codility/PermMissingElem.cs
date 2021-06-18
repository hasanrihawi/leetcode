using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class PermMissingElem
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0)
                return 1;
            if (A.Length == 1)
                if (A[0] == 1)
                    return 2;
                else
                    return 1;
            
            var AList = A.ToList();
            AList.Sort();
            for (int i = 0; i < AList.Count; i++)
            {
                if (AList[i] > i + 1)
                    return AList[i] - 1;
            }
            return AList[AList.Count - 1] +1;
        }
    }
}
