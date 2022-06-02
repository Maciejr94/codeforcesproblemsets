using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class TrimABinarySearchTree
    {
        public static TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null) return root;

            while (root.val < low || root.val > high)
            {
                root = root.val < low ? root.right : root.left;
            }

            TreeNode left = root.left;
            TreeNode parent = root;
            while (left != null)
            {
                if (left.val >= low)
                {
                    parent = left;
                    left = left.left != null ? left.left : left.right;
                }
                else
                {
                    parent.left = left.right; 
                    left = parent.left;
                }
            }
            TreeNode right = root.right;
            parent = root;
            while (right != null)
            {
                if (right.val <= high)
                {
                    parent = right;
                    right = right.right != null ? right.right : right.left;
                }
                else
                {
                    parent.right = right.left; 
                    right = parent.right;
                }
            }

            //if (root == null)
            //    return root;

            //if (root.val > high)
            //    return TrimBST(root.left, low, high);

            //if (root.val < low)
            //    return TrimBST(root.right, low, high);

            //root.left = TrimBST(root.left, low, high);
            //root.right = TrimBST(root.right, low, high);
            return root;
        }
    }
}
