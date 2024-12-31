using static LeetCode.Solution2;

namespace LeetCode
{
    public class Solution19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // Create a dummy node to handle edge cases easily
            ListNode dummy = new ListNode(0, head);
            ListNode first = dummy;
            ListNode second = dummy;

            // Move the first pointer n+1 steps ahead
            for (int i = 0; i <= n; i++)
            {
                first = first.next;
            }

            // Move both pointers until the first pointer reaches the end
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            // Remove the nth node from the end
            second.next = second.next.next;

            // Return the new head (skip the dummy node)
            return dummy.next;
        }
    }
}
