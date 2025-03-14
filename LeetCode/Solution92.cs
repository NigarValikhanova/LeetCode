using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution92
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right) return head;

            // Create a dummy node to simplify edge cases like reversing from the head
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prev = dummy;

            // Move `prev` to the node just before `left`
            for (int i = 1; i < left; i++)
            {
                prev = prev.next;
            }

            // The `start` node is the first node to be reversed
            ListNode start = prev.next;
            ListNode then = start.next;

            // Reverse the sublist between `left` and `right`
            for (int i = 0; i < right - left; i++)
            {
                start.next = then.next;
                then.next = prev.next;
                prev.next = then;
                then = start.next;
            }

            return dummy.next;
        }
    }

}
