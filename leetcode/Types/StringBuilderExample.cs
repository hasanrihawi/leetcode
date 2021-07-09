using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Types
{
    class StringBuilderExample
    {
        public StringBuilderExample()
        {
            // C# allocates a maximum of 50 spaces sequentially on the memory heap.
            StringBuilder sb1 = new StringBuilder(50);

            StringBuilder sb = new StringBuilder("Hello World!");
            sb.Append("Hello ");
            sb.AppendLine("World!");
            var greet = sb.ToString();

            // Use the Insert() method inserts a string at the specified index in the StringBuilder object.
            sb.Insert(5, " C#");

            // Use the Remove() method to remove a string from the specified index and up to the specified length.
            sb.Remove(6, 7);

            sb.Replace("World", "C#");

        }
    }
}
