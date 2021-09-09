using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace leetcode.hackerRank
{
    public class SolutionCountTriplets
    {
        public static long CountTriplets(List<long> arr, long r)
        {
            ConcurrentDictionary<long, long> potential = new ConcurrentDictionary<long, long>();
            ConcurrentDictionary<long, long> counter = new ConcurrentDictionary<long, long>();
            long count = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                long a = arr[i];
                long key = a / r;

                if (counter.ContainsKey(key) && a % r == 0)
                {
                    count += counter.GetValueOrDefault(key);
                }

                if (potential.ContainsKey(key) && a % r == 0)
                {
                    long c = potential.GetValueOrDefault(key);
                    counter.AddOrUpdate(a, c, (k, oldValue) => oldValue + c);
                }

                long d = potential.GetValueOrDefault(a, 0L) +1;
                potential.AddOrUpdate(a, d, (k, oldValue) => oldValue + d);
            }
            return count;
        }
    }
}
