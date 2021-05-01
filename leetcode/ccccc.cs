using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class Solution
    {
        public int solution(int N, int K, int[] A, int[] B, int[] C)
        {
            Dictionary<int, List<int>> falvores = new Dictionary<int, List<int>>();
            HashSet<int> badCakes = new HashSet<int>();
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            for (int instructionIndex = 0; instructionIndex < C.Length; instructionIndex++)
            {
                int instructionFlavor = C[instructionIndex];
                int instructionStart = A[instructionIndex];
                int instructionEnd = B[instructionIndex];
                if (falvores.ContainsKey(instructionFlavor))
                {
                    List<int> rangesList;
                    falvores.TryGetValue(instructionFlavor,  out rangesList);

                    if (instructionEnd == instructionStart)
                    {
                        rangesList.Add(instructionStart);
                    }
                    else if (instructionEnd > instructionStart)
                    {
                        var range = Enumerable.Range(instructionStart, instructionEnd - instructionStart +1);
                        rangesList.AddRange(range);
                    }
                    falvores[instructionFlavor] = rangesList;
                }
                else
                {
                    var list = new List<int>();
                    if (instructionEnd == instructionStart)
                    {
                        list.Add(instructionStart);
                    }
                    else if (instructionEnd > instructionStart)
                    {
                        var range = Enumerable.Range(instructionStart, instructionEnd - instructionStart + 1);
                        list.AddRange(range);
                    }
                    falvores.Add(instructionFlavor, list);
                }
            }

            var cakes = Enumerable.Range(1, N);

            foreach (var flavor in falvores)
            {
                if (flavor.Key <= K)
                {
                    var flavorShareList = flavor.Value;

                    HashSet<int> hs = new HashSet<int>();

                    // finding missing items
                    var missingCakes = cakes.Except(flavorShareList);

                    //finding duplicates items
                    var duplicatedCakes = flavorShareList.GroupBy(x => x)
                       .Where(g => g.Count() > 1)
                       .Select(y => y.Key)
                       .ToList();

                    foreach (var m in missingCakes)
                        badCakes.Add(m);
                    foreach (var d in duplicatedCakes)
                        badCakes.Add(d);
                }
            }

            // finding good cakes by execludind bad cakes
            var goodCakes = cakes.Except(badCakes);

            return goodCakes.Count();
        }

        //public int solution(int N, int K, int[] A, int[] B, int[] C)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    int goodCakes = 0;
        //    for (int i = 1; i <= N; i++)
        //    {
        //        List<int> cakeFormResult = new List<int>();
        //        for (int instructionIndex = 0; instructionIndex < C.Length; instructionIndex++)
        //        {
        //            int instructionFlavor = C[instructionIndex];
        //            int instructionStart = A[instructionIndex];
        //            int instructionEnd = B[instructionIndex];
        //            if (i >= instructionStart && i <= instructionEnd)
        //                cakeFormResult.Add(instructionFlavor);
        //        }
        //        if (cakeFormResult.Count == K && cakeFormResult[cakeFormResult.Count - 1] == K)
        //            goodCakes++;
        //    }
        //    return goodCakes;
        //}
    }
}
