using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SwappingNodesInALinkedList
    {
        public static ListNode SwapNodes(ListNode head, int k)
        {
            #region another two pointers i guess
            //ListNode firstNode = null;
            //ListNode secondNode = null;
            //ListNode newHead = head;
            //int i = 1;

            //while (newHead != null)
            //{
            //    if (secondNode != null)
            //        secondNode = secondNode.next;

            //    if (i == k)
            //    {
            //        firstNode = newHead;
            //        secondNode = head;
            //    }

            //    newHead = newHead.next;
            //    i++;
            //}

            //int temp = firstNode.val;
            //firstNode.val = secondNode.val;
            //secondNode.val = temp;

            //return head;
            #endregion
            #region two pointers
            //ListNode newHead = new ListNode();
            //newHead.next = head;
            //ListNode fast = newHead;
            //ListNode slow = newHead;

            //while (k > 0)
            //{
            //    k--;
            //    fast = fast.next;
            //}

            //ListNode firstNode = fast;

            //while (fast != null)
            //{
            //    fast = fast.next;
            //    slow = slow.next;
            //}

            //ListNode secondNode = slow;

            //int temp = firstNode.val;
            //firstNode.val = secondNode.val;
            //secondNode.val = temp;

            //return newHead.next;
            #endregion
            #region List<ListNode> ^^
            List<ListNode> list = new List<ListNode>();

            ListNode current = head;

            while(current != null)
            {
                list.Add(current);
                current = current.next;
            }

            int temp = list[k - 1].val;
            list[k - 1].val = list[list.Count() - k].val;
            list[list.Count() - k].val = temp;

            return head;
            #endregion
        }
    }
}
