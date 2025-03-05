using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode3
    {
        public int val;
        public ListNode3 next;
        public ListNode3(int val = 0, ListNode3 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode3 DeleteDuplicates(ListNode3 head)
        {
            if (head == null) return null;

            ListNode3 current = head;

            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next; // Skip duplicate node
                }
                else
                {
                    current = current.next; // Move to next distinct node
                }
            }

            return head;
        }
    }

}
