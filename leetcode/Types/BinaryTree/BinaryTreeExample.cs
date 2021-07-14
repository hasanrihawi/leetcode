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
            else if (v < root.data)
                root.left = insert(root.left, v);
            else
                root.right = insert(root.right, v);

            return root;
        }

        bool checkBST(BinaryNode root, int min, int max)
        {
            if (root == null) return true;
            return root.data > min && root.data < max &&
                checkBST(root.left, min, root.data) &&
                checkBST(root.right, root.data, max);
        }

        public void traverse(BinaryNode root)
        {
            if (root == null)
            {
                Console.Write(root.data + " ");
                return;
            }

            traverse(root.left);
            traverse(root.right);
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

            if (key < root.data) 
                root.left = Remove(root.left, key);
            else if (key > root.data)
                root.right = Remove(root.right, key);
            else
            {
                // if value is same as parent's value, then this is the node to be deleted  
                // node with only one child or no child  
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                root.data = MinValue(root.right);

                // Delete the inorder successor  
                root.right = Remove(root.right, root.data);
            }

            return root;
        }

        private int MinValue(BinaryNode node)
        {
            int minv = node.data;

            while (node.left != null)
            {
                minv = node.left.data;
                node = node.left;
            }

            return minv;
        }

        private BinaryNode Find(int value, BinaryNode parent)
        {
            if (parent != null)
            {
                if (value == parent.data) return parent;
                if (value < parent.data)
                    return Find(value, parent.left);
                else
                    return Find(value, parent.right);
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(BinaryNode parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.left), GetTreeDepth(parent.right)) + 1;
        }

        public void TraversePreOrder(BinaryNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.data + " ");
                TraversePreOrder(parent.left);
                TraversePreOrder(parent.right);
            }
        }

        public void TraverseInOrder(BinaryNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.left);
                Console.Write(parent.data + " ");
                TraverseInOrder(parent.right);
            }
        }

        public void TraversePostOrder(BinaryNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.left);
                TraversePostOrder(parent.right);
                Console.Write(parent.data + " ");
            }
        }
    }

    class BinaryNode
    {
        public BinaryNode(int data)
        {
            this.data = data;
        }
        public BinaryNode left { get; set; }
        public BinaryNode right { get; set; }
        public int data { get; set; }
    }
}
