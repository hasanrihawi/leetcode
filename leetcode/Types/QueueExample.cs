using System;

namespace leetcode.Types
{
    public class MyQueue<T>
    {
        private class QueueNode<T>
        {
            public T data;
            public QueueNode<T> next;

            public QueueNode(T data)
            {
                this.data = data;
            }
        }


        private QueueNode<T> first;
        private QueueNode<T> last;

        public void add(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);
            if (last != null)
            {
                last.next = t;
            }
            last = t;
            if (first == null)
            {
                first = last;
            }
        }

        public T remove()
        {

            if (first == null) throw new Exception();
            T data = first.data;
            first = first.next;
            if (first == null)
            {
                last = null;
            }
            return data;
        }

        public T peek()
        {
            if (first == null) throw new Exception();
            return first.data;
        }

        public bool isEmpty()
        {
            return first == null;
        }
    }
}

