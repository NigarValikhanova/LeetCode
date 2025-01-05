using static LeetCode.Solution2;

namespace LeetCode
{
    public class Solution24
    {
        public ListNode SwapPairs(ListNode head)
        {
            // Create a dummy node to simplify edge cases
            ListNode dummy = new ListNode(0, head);
            ListNode prev = dummy;

            while (prev.next != null && prev.next.next != null)
            {
                // Identify the nodes to swap
                ListNode first = prev.next;
                ListNode second = prev.next.next;

                // Swap the nodes
                first.next = second.next;
                second.next = first;
                prev.next = second;

                // Move the pointer to the next pair
                prev = first;
            }

            return dummy.next;
        }
    }
}
