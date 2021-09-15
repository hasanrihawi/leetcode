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
                    _ = counter.TryGetValue(key, out var value) ? value : default(long);
                    count += value;
                }

                if (potential.ContainsKey(key) && a % r == 0)
                {
                    _ = potential.TryGetValue(key, out var value) ? value : default(long);
                    counter.AddOrUpdate(a, value, (k, oldValue) => oldValue + value);
                }

                _ = potential.TryGetValue(key, out var d) ? d : default(long);
                potential.AddOrUpdate(a, d + 1, (k, oldValue) => oldValue + d + 1);
            }
            return count;
        }
    }
}
