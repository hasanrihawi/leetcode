using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class pppppp
    {
        public int solution(int N, int K, int[] A, int[] B, int[] C)
        {
            Dictionary<int, List<int>> cakes = new Dictionary<int, List<int>>();
            foreach (var cake in Enumerable.Range(1, N))
                cakes.Add(cake, new List<int>());

            for (int i = 0; i < C.Length; i++)
            {
                int currentLayer = C[i];
                for (int j = A[i]; j <= B[i]; j++)
                {
                    List<int> layersList;
                    if (cakes.TryGetValue(j, out layersList))
                    {
                        if (layersList.Count == 0 && currentLayer == 1 || layersList.Count > 0 && currentLayer == layersList.Last() + 1)
                        {
                            layersList.Add(currentLayer);
                            cakes[j] = layersList;
                        }
                        else
                            cakes.Remove(j);
                    }
                }
                   
            }

            return cakes.Count();
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
