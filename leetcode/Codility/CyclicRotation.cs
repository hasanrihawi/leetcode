using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Arrays
{
    public class CyclicRotation
    {
        public static int[] rotLeft(int[] a, int d)
        {
            int[] rotated = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                int newIndex = (i + d) % a.Length;
                rotated[newIndex] = a[i];
            }
            return rotated;
        }
    }
}
