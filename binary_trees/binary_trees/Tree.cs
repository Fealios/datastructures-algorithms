using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_trees
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int _val) { val = _val; } // constructor
    }
    class Tree
    {
        public TreeNode root;

        public Tree()
        {
            root = null;
        }

        TreeNode insertRec(TreeNode root, int key)
        {

            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new TreeNode(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.val)
                root.left = insertRec(root.left, key);
            else if (key > root.val)
                root.right = insertRec(root.right, key);

            /* return the (unchanged) node pointer */
            return root;
        }

        public void PrintTree(TreeNode node)
        {
            Console.WriteLine(node.val);
            PrintTree(node.left);
            PrintTree(node.right);
        }
    }
}
