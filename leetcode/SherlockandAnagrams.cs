using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class SherlockandAnagrams
    {
        public static int sherlockAndAnagrams(string input)
        {
            var hashedAnagrams = new ConcurrentDictionary<int, int>();

            for (var i = 1; i < input.Length; i++)
            {
                for (var j = 0; j <= input.Length - i; j++)
                {
                    var subInput = input.Substring(j, i);
                    var key = GetHashedAnagram(subInput);
                    hashedAnagrams.AddOrUpdate(key, 1, (id, count) => count + 1);
                }
            }


            int anagrammaticPairs = 0;
            foreach (var count in hashedAnagrams)
                anagrammaticPairs += count.Value * (count.Value - 1) / 2;

            return anagrammaticPairs;
        }


        public static int GetHashedAnagram(string subInput)
        {
            var frequencyTable = new ConcurrentDictionary<char, int>();
            foreach (char c in subInput)
                frequencyTable.AddOrUpdate(c, 1, (id, count) => count + 1);
            StringBuilder key = new StringBuilder();

            foreach (var item in frequencyTable.OrderBy(s => s.Key))
            {
                key.Append(item.Key + item.Value.ToString());
            }

            return key.ToString().GetHashCode();
        }

    }
}
