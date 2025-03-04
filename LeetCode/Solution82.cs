using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class ListNode2
    {
        public int val;
        public ListNode2 next;
        public ListNode2(int val = 0, ListNode2 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution82
    {
        public ListNode2 DeleteDuplicates(ListNode2 head)
        {
            if (head == null || head.next == null) return head;

            ListNode2 dummy = new ListNode2(0, head); // Dummy node to handle edge cases
            ListNode2 prev = dummy;

            while (head != null)
            {
                // Check if it's a duplicate
                if (head.next != null && head.val == head.next.val)
                {
                    // Skip all duplicates
                    while (head.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }
                    prev.next = head.next; // Remove all occurrences
                }
                else
                {
                    prev = prev.next; // Move prev pointer only if no duplicate
                }
                head = head.next; // Move to the next node
            }

            return dummy.next;
        }
    }
}
