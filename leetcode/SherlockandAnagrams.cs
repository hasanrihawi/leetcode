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
            var hashedAnagrams = new ConcurrentDictionary<string, int>();

            for (var currSubLength = 1; currSubLength < input.Length; currSubLength++)
            {
                for (var j = 0; j <= input.Length - currSubLength; j++)
                {
                    var subInput = input.Substring(j, currSubLength);
                    var key = GetHashedAnagram(subInput);
                    hashedAnagrams.AddOrUpdate(key, 1, (id, count) => count + 1);
                }
            }

            int anagrammaticPairs = 0;
            foreach (var count in hashedAnagrams)
                anagrammaticPairs += count.Value * (count.Value - 1) / 2;

            return anagrammaticPairs;
        }


        public static string GetHashedAnagram(string subInput)
        {
            var frequencyTable = new ConcurrentDictionary<char, int>();
            foreach (char c in subInput)
                frequencyTable.AddOrUpdate(c, 1, (id, count) => count + 1);
            StringBuilder key = new StringBuilder();

            foreach (var item in frequencyTable.OrderBy(s => s.Key))
                key.Append(item.Key + item.Value.ToString());
            
            // we could use key.ToString().GetHashCode();
            return key.ToString();
        }

    }
}
