using System;

namespace leetcode.Types
{
    class BinaryTreeExample
    {
        public BinaryNode Root { get; set; }

        public BinaryNode insert(BinaryNode root, int v)
        {
            if (root == null)
                root = new BinaryNode(v);
            else if (v < root.Value)
                root.Left = insert(root.Left, v);
            else
                root.Right = insert(root.Right, v);

            return root;
        }

        bool checkBST(BinaryNode root, int min, int max)
        {
            if (root == null) return true;
            return root.Value > min && root.Value < max &&
                checkBST(root.Left, min, root.Value) &&
                checkBST(root.Right, root.Value, max);
        }

        public void traverse(BinaryNode root)
        {
            if (root == null)
            {
                Console.Write(root.Value + " ");
                return;
            }

            traverse(root.Left);
            traverse(root.Right);
        }

        public BinaryNode Find(int value)
        {
            return this.Find(value, this.Root);
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private BinaryNode Remove(BinaryNode root, int key)
        {
            if (root == null) return root;

            if (key < root.Value) root.Left = Remove(root.Left, key);
            else if (key > root.Value)
                root.Right = Remove(root.Right, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                root.Value = MinValue(root.Right);

                // Delete the inorder successor  
                root.Right = Remove(root.Right, root.Value);
            }

            return root;
        }

        private int MinValue(BinaryNode node)
        {
            int minv = node.Value;

            while (node.Left != null)
            {
                minv = node.Left.Value;
                node = node.Left;
            }

            return minv;
        }

        private BinaryNode Find(int value, BinaryNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Value) return parent;
                if (value < parent.Value)
                    return Find(value, parent.Left);
                else
                    return Find(value, parent.Right);
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(BinaryNode parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.Left), GetTreeDepth(parent.Right)) + 1;
        }

        public void TraversePreOrder(BinaryNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Value + " ");
                TraversePreOrder(parent.Left);
                TraversePreOrder(parent.Right);
            }
        }

        public void TraverseInOrder(BinaryNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.Left);
                Console.Write(parent.Value + " ");
                TraverseInOrder(parent.Right);
            }
        }

        public void TraversePostOrder(BinaryNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.Left);
                TraversePostOrder(parent.Right);
                Console.Write(parent.Value + " ");
            }
        }
    }

    class BinaryNode
    {
        public BinaryNode(int value)
        {
            this.Value = value;
        }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }
        public int Value { get; set; }
    }
}
