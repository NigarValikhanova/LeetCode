namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution61
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null || k == 0)
                return head;

            // Find the length of the list
            ListNode current = head;
            int length = 1;
            while (current.next != null)
            {
                current = current.next;
                length++;
            }

            // Make the list circular
            current.next = head;

            // Find the new tail position
            k = k % length;
            int stepsToNewTail = length - k;

            // Find the new tail and the new head
            ListNode newTail = head;
            for (int i = 1; i < stepsToNewTail; i++)
            {
                newTail = newTail.next;
            }

            ListNode newHead = newTail.next;
            newTail.next = null; // Break the cycle

            return newHead;
        }
    }

}
