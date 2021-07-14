using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Types
{
    public class BinaryTreeExample3
    {
        public BinaryTreeExample3()
        {
            BinaryNode root = new BinaryNode(3);
            var res = isBST(root, null, null);
            var res2 = isBST2(root, int.MinValue, int.MaxValue);
        }

        bool isBST(BinaryNode root, BinaryNode l, BinaryNode r)
        {
            // Base condition
            if (root == null)
                return true;

            // if left node exist then check it has
            // correct data or not i.e. left node's data
            // should be less than root's data
            if (l != null && root.data <= l.data)
                return false;

            // if right node exist then check it has
            // correct data or not i.e. right node's data
            // should be greater than root's data
            if (r != null && root.data >= r.data)
                return false;

            // check recursively for every node.
            return isBST(root.left, l, root) &&
                isBST(root.right, root, r);
        }

        bool isBST2(BinaryNode node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
                return true;

            /* false if this node violates the min/max constraints */
            if (node.data < min || node.data > max)
            {
                return false;
            }

            /* otherwise check the subtrees recursively
            tightening the min/max constraints */
            // Allow only distinct values
            return (isBST2(node.left, min, node.data - 1) && isBST2(node.right, node.data + 1, max));
        }



    }
}
