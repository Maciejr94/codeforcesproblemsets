using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class RecoverBinarySearchTree
    {
        public static TreeNode first = null;
        public static TreeNode second = null;
        public static TreeNode prev = null;

        public static void RecoverTree(TreeNode root)
        {
            BST(root);

            int temp = first.val;
            first.val = second.val;
            second.val = temp;
        }

        public static void BST(TreeNode root)
        {
            if (root == null)
                return;

            BST(root.left);

            if(prev != null && prev.val > root.val) {
                if (first == null)
                {
                    first = prev;
                    second = root;
                }
                else
                    second = root;
            }

            prev = root;

            BST(root.right);
        }
    }
}
