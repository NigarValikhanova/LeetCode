using static LeetCode.Solution2;

namespace LeetCode
{
    public class Solution21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to act as the start of the merged list
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            // Merge the two lists by comparing values
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Append the remaining nodes of list1 or list2
            current.next = list1 != null ? list1 : list2;

            // Return the merged list starting from the first node after the dummy
            return dummy.next;
        }
    }
}
