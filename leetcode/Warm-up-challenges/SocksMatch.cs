using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Warm_up_challenges
{
    class SocksMatch
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            //var xx = ar.GroupBy(x => x).Select(x => new { key = x.Key, value = x.Count(), pairs=x.Count() / 2 });
            var x = ar.GroupBy(x => x).Select(x =>  x.Count() / 2).Sum();
            return x;
        }
    }
}
