using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Types
{
    class LinkedListExample
    {
        public LinkedListExample()
        {
            LinkedList<String> my_list = new LinkedList<string>();
            my_list.AddLast("Zoya");
            var Last = my_list.Last;
            var First = my_list.First;

        }
    }

    class Node
    {
        Node next = null;
        int data;

        public Node(int d)
        {
            data = d;
        }

        void appendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
                n.next = end;
            }

        }

        Node deleteNode(Node head, int d)
        {
            Node n = head;
            if (n.data == d)
            {
                return head.next;
            }
            while (n.next != null)
            {
                if (n.next.data == d)
                {
                    n.next = n.next.next;
                    return head; /* head didn't change*/
                }
                n = n.next;
            }
            return head;
        }
    }

    
}
