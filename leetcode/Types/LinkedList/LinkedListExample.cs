using System;

namespace leetcode.Types
{
    class SimpleNode
    {
        SimpleNode next = null;
        readonly int data;

        public SimpleNode(int d)
        {
            data = d;
        }

        // function to insert a Node at required position
        static SimpleNode Insert(SimpleNode headNode,
                            int position, int data)
        {
            var head = headNode;
            if (position < 1)
                Console.WriteLine("Invalid position");

            //if position is 1 then new node is
            // set infornt of head node
            //head node is changing.
            if (position == 1)
            {
                var newNode = new SimpleNode(data);
                newNode.next = headNode;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        // adding Node at required position
                        SimpleNode newNode = new SimpleNode(data);

                        // Making the new Node to point to
                        // the old Node at the same position
                        newNode.next = headNode.next;

                        // Replacing current with new Node
                        // to the old Node to point to the new Node
                        headNode.next = newNode;
                        break;
                    }
                    headNode = headNode.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        public static SimpleNode insert2(SimpleNode head, int data, int position)
        {
            SimpleNode nodeToInsert = new SimpleNode(data);

            //Empty List - Returned newly created SimpleNode or null
            if (head == null) { return nodeToInsert; }

            //Inserting a Node ahead of the List
            if (position == 0)
            {
                nodeToInsert.next = head;
                return nodeToInsert;
            }

            //Traverse the Singly Linked List to 1 Position Prior
            //Stop traversing if you reached the end of the List

            SimpleNode temp = head;
            int currPosition = 0;

            while (currPosition < position - 1 && temp.next != null)
            {
                temp = temp.next;
                currPosition++;
            }

            //Inserting a SimpleNode in-between a List or at the end of of a List
            SimpleNode nodeAtPosition = temp.next;
            temp.next = nodeToInsert;
            temp = temp.next;
            temp.next = nodeAtPosition;

            return head;
        }


        void appendToTail(int d)
        {
            SimpleNode end = new SimpleNode(d);
            SimpleNode n = this;
            while (n.next != null)
            {
                n = n.next;
                n.next = end;
            }
        }

        SimpleNode deleteSimpleNode(SimpleNode head, int d)
        {
            SimpleNode n = head;
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
