using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class NodeTree
    {
        public int val;
        public NodeTree left;
        public NodeTree right;
        public NodeTree next;

        public NodeTree() { }

        public NodeTree(int _val)
        {
            val = _val;
        }

        public NodeTree(int _val, NodeTree _left, NodeTree _right, NodeTree _next = null)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    public static class PopulatingNextRightPointersInEachNode
    {
        //with previous variable
        //public static NodeTree Connect(NodeTree root)
        //{
        //    if (root == null)
        //        return root;

        //    Queue<NodeTree> que = new Queue<NodeTree>();
        //    que.Enqueue(root);
        //    while (que.Count > 0)
        //    {
        //        int n = que.Count;

        //        NodeTree prev = null;

        //        for(int i = 0; i < n; i++)
        //        {
        //            NodeTree node = que.Dequeue();
        //            if (prev == null)
        //                prev = node;
        //            else
        //            {
        //                prev.next = node;
        //                prev = node;
        //            }

        //            if (node.left != null)
        //                que.Enqueue(node.left);

        //            if (node.right != null)
        //                que.Enqueue(node.right);


        //        }
        //        prev.next = null;
        //    }

        //        return root;
        //}

        public static NodeTree Connect(NodeTree root)
        {
            if (root == null)
                return null;

            NodeTree leftMost = root;

            while (leftMost.left != null)
            {
                NodeTree curr = leftMost;
                while (curr != null)
                {
                    curr.left.next = curr.right;

                    if (curr.next != null)
                    {
                        curr.right.next = curr.next.left;
                    }

                    curr = curr.next;
                }

                leftMost = leftMost.left;
            }

            return root;
        }

    }
}
