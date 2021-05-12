using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace leetcode
{
    public class Node
    {
        private List<Node> _children;

        public Node(int data, params Node[] nodes)
        {
            Data = data;
            AddRange(nodes);
        }

        public Node Parent { get; set; }

        public IEnumerable<Node> Children
        {
            get
            {
                return _children != null
                    ? _children.AsReadOnly()
                    : Enumerable.Empty<Node>();
            }
        }

        public int Data { get; private set; }

        public void Add(Node node)
        {
            Debug.Assert(node.Parent == null);

            if (_children == null)
            {
                _children = new List<Node>();
            }

            _children.Add(node);
            node.Parent = this;
        }

        public void AddRange(IEnumerable<Node> nodes)
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
        public static Node Previous(this Node node)
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
