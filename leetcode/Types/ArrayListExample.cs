using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Types
{
    class ArrayListExample
    {
        // In C#, the ArrayList is a non-generic collection of objects whose size increases dynamically. 
        // It is the same as Array except that its size increases dynamically.
        public ArrayListExample()
        {
            var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            //Access individual item using indexer
            int firstElement = (int)arlist[0]; //returns 1
            string secondElement = (string)arlist[1]; //returns "Bill"
            //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            //using var keyword without explicit casting
            var firstElement1 = arlist[0]; //returns 1
            var secondElement1 = arlist[1]; //returns "Bill"
            //update elements
            arlist[0] = "Steve";
            arlist[1] = 100;
        }
    }
}
