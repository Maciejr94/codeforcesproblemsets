using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    
    public static class FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
    {
        private static TreeNode result;
        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {

            DFSInOrder(original, cloned, target);
            return result;
        }

        private static void DFSInOrder(TreeNode original, TreeNode clone, TreeNode target)
        {
            if(original != null)
            {
                DFSInOrder(original.left, clone.left, target);
                if (original == target)
                    result = clone;

                DFSInOrder(original.right, clone.right, target);
            }
            
        }
    }
}
