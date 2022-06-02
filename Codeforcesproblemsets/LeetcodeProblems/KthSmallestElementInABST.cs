using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class KthSmallestElementInABST
    {
        public static int KthSmallest(TreeNode root, int k)
        {
            List<int> nums = InOrder(root, new List<int>());
            return nums[k - 1];
        }

        public static List<int> InOrder(TreeNode root, List<int> arr)
        {
            if (root == null)
                return arr;
            InOrder(root.left, arr);
            arr.Add(root.val);
            InOrder(root.right, arr);
            return arr;
        }
    }


}
