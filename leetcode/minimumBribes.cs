using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class MinimumBribesResult
    {
        public static void minimumBribes(List<int> queue)
        {
            int bribes = 0;
            for (int i = 0; i < queue.Count(); i++)
            {
                if (queue[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                for (int j = Math.Min(queue[i] + 2, queue.Count() -1 ); j > i; j--)
                {
                    if (queue[j] < queue[i])
                        bribes++;
                }
            }
            Console.WriteLine(bribes);
        }

    }

}
