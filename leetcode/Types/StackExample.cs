using System.Collections.Generic;
using System.Text;

namespace leetcode.Types
{
    class StackExample
    {
        public StackExample()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack0 = new Stack<int>(arr);

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Peek();
            myStack.Pop();

            /*
             
            Push(T) Inserts an item at the top of the stack.
            Peek()  Returns the top item from the stack.
            Pop()   Removes and returns items from the top of the stack.
            Contains(T) Checks whether an item exists in the stack or not.
            Clear() Removes all items from the stack.

            */
        }
    }
}

