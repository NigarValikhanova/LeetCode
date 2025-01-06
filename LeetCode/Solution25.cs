using static LeetCode.Solution2;

namespace LeetCode
{
    public class Solution25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k == 1) return head;

            // Dummy node to simplify edge cases
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prevGroupEnd = dummy;

            while (true)
            {
                // Check if there are at least k nodes to reverse
                ListNode groupStart = prevGroupEnd.next;
                ListNode groupEnd = prevGroupEnd;
                for (int i = 0; i < k; i++)
                {
                    groupEnd = groupEnd.next;
                    if (groupEnd == null) return dummy.next; // Fewer than k nodes left
                }

                // Reverse the group
                ListNode nextGroupStart = groupEnd.next;
                Reverse(groupStart, groupEnd);

                // Connect reversed group with the rest of the list
                prevGroupEnd.next = groupEnd;
                groupStart.next = nextGroupStart;

                // Move prevGroupEnd to the end of the reversed group
                prevGroupEnd = groupStart;
            }
        }

        private void Reverse(ListNode start, ListNode end)
        {
            ListNode prev = null;
            ListNode current = start;
            ListNode stop = end.next;

            while (current != stop)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
        }
    }
}
