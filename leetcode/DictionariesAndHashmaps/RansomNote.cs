using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DictionariesAndHashmaps
{
    class RansomNote
    {
        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            magazine.Sort();
            note.Sort();

            foreach (string ransom_w in note)
            {
                if (!magazine.Remove(ransom_w))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
