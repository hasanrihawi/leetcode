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
