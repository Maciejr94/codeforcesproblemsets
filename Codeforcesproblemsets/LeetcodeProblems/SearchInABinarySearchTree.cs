using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SearchInABinarySearchTree
    {
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;

            if (root.val == val)
                    return root;

            return root.val > val ? SearchBST(root.left, val) : SearchBST(root.right, val);
        }

        //public static void BST(TreeNode root, int val)
        //{
        //    if (root == null)
        //        return null;

        //    if (root.val == val)
        //        return root;

        //    BST(root.left, val);
        //    BST(root.right, val);
        //}
    }
}
