using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class ccccc
    {
        public string solution(string S)
        {
            //List<string> foundedNames1 = B.Where(item => item.Contains(P)).ToList();
            //List<string> foundedNames = B.Where(item => item.Contains(P)).Select((item, index) => A[index]).ToList();
            // edit
            StringBuilder result = new StringBuilder();

            var cleanedText = new string(S.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .Where(c => c != '-')
                .ToArray());


            int index = 0;
            while (index < cleanedText.Length)
            {
                int length = 2;
                var sl = (cleanedText.Length - index) / 3;
                var remain = (cleanedText.Length - index) % 3;
                if (sl == 1 && remain == 0)
                    length = 3;
                else if(sl == 1 && remain < 2)
                    length = 2;
                else
                {
                    length = 3;
                }
                if(index+length < cleanedText.Length)
                result.Append(cleanedText.Substring(index, length));
                else
                    result.Append(cleanedText.Substring(index));
                result.Append('-');
                var ss = result.ToString();
                index = index + length;
            }

            

            var s= result.ToString();
            if (s.Last() == '-')
                s = s.Remove(s.Length - 1);
            
            return s;
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
