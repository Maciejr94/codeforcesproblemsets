using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class RotateList
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)
                return head;

            ListNode slow = head;
            ListNode fast = head;
            int count = 0;

            while (fast != null)
            {
                fast = fast.next;
                count++;
            }
            fast = head;

            k %= count;

            while (k > 0)
            {
                fast = fast.next;
                k--;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            fast.next = head;
            ListNode newHead = slow.next;
            slow.next = null;



            return newHead;
        }
    }
}
