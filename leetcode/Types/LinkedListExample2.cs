using System.Collections.Generic;

namespace leetcode.Types
{
    class LinkedListExample
    {
        public LinkedListExample()
        {
            LinkedList<string> my_list = new LinkedList<string>();
            my_list.AddLast("Zoya");
            var Last = my_list.Last;
            var First = my_list.First;
        }
    }
}
