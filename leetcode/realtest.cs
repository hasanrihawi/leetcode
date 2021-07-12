using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace leetcode
{
    public class Node1
    {
        private List<Node1> _children;

        public Node1(int data, params Node1[] nodes)
        {
            Data = data;
            AddRange(nodes);
        }

        public Node1 Parent { get; set; }

        public IEnumerable<Node1> Children
        {
            get
            {
                return _children != null
                    ? _children.AsReadOnly()
                    : Enumerable.Empty<Node1>();
            }
        }

        public int Data { get; private set; }

        public void Add(Node1 node)
        {
            Debug.Assert(node.Parent == null);

            if (_children == null)
            {
                _children = new List<Node1>();
            }

            _children.Add(node);
            node.Parent = this;
        }

        public void AddRange(IEnumerable<Node1> nodes)
        {
            foreach (var node in nodes)
            {
                Add(node);
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public static class NodeExtensions
    {
        public static Node1 Previous(this Node1 node)
        {
            if (node.Parent == null) { return null; }
            var brothers = node.Parent.Children.ToList();
            var index = brothers.IndexOf(node);
            if (index == 0)
            {
                return node.Parent;
            }
            else
            {
                var next = brothers[index - 1];
                while (next.Children.Any())
                {
                    next = next.Children.Last();
                }
                return next;
            }
        }

    }

}
