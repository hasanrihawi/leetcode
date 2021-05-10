using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Arrays
{
    public class hourglass2DArray
    {
        static int hourglassSum(int[][] arr)
        {
            List<int> sum = new List<int>();
            for (int i = 0; i < arr.Length - 2; i++)
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    sum.Add(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
                }
            return sum.Max();

        }
    }
}
