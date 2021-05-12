using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Warm_up_challenges
{
    class CountingValley
    {
        public static int countingValleys(int steps, string path)
        {
            int currentPlace = 0;
            int valleyCount = 0;
            for (int i = 0; i < steps; i++)
            {
                int previousPlace = currentPlace;
                if (path[i] == 'U')
                    currentPlace++;
                else currentPlace--;
                if (previousPlace == 0 && currentPlace == -1)
                    valleyCount++;
            }
            return valleyCount;
        }
    }
}
