using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Arrays
{
    class rotateLeftArray
    {
        static int[] rotLeft(int[] a, int d)
        {
            int[] rotated = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                int newIndex = (i + d) % a.Length;
                rotated[i] = a[newIndex];
            }
            return rotated;
        }
    }
}
