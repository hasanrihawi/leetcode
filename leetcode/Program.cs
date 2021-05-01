using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var x = new LengthOfLongestSubstringSolution2().lengthOfLongestSubstring("au");


            //new LongestPalindromeSolution().LongestPalindrome("au");
            //var res =  new ZigzagConversionSolution().Convert("PAYPALISHIRING", 3) == "PAHNAPLSIIGYIR";
            //var res = new StringToIntegerAtoi().MyAtoi("  +  413");
            //var res = new PalindromeNumber().IsPalindrome2(121);
            //var res = new Solution().solution(5, 3, new int[]{1, 1, 4, 1, 4}, new int[] { 5, 2, 5, 5, 4 }, new int[] { 1, 2, 2, 3, 3 });
            var res = new Solution().solution(3, 2, new int[]{ 1, 3, 3, 1, 1 }, new int[] { 2, 3, 3, 1, 2 }, new int[] { 1, 2, 1, 2, 2 });
        }
    }
}
