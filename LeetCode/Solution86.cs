using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution86
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode beforeHead = new ListNode(0); // Dummy node for smaller values
            ListNode before = beforeHead;
            ListNode afterHead = new ListNode(0);  // Dummy node for greater/equal values
            ListNode after = afterHead;

            while (head != null)
            {
                if (head.val < x)
                {
                    before.next = head;
                    before = before.next;
                }
                else
                {
                    after.next = head;
                    after = after.next;
                }
                head = head.next;
            }

            after.next = null; // Ensure the last node of 'after' list does not create a cycle
            before.next = afterHead.next; // Merge the two lists

            return beforeHead.next;
        }
    }
}
