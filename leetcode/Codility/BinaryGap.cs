using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace leetcode
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binary = Convert.ToString(N, 2);
            string pattern = @"(1)+(0{1,})(?=(1))";
            Regex rg = new Regex(pattern);
            MatchCollection matchedAuthors = rg.Matches(binary);
            return matchedAuthors.Count > 0 ? matchedAuthors
            .Cast<Match>()
            .Max(x => x.Value.Where(c => c == '0').ToList().Count) : 0;
        }
    }
}
