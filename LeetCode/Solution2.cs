namespace LeetCode
{
    public class Solution2
    {
        //This is the medium level problem
        /**
            * Definition for singly-linked list.*/

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummyHead = new ListNode(0); // Dummy head to simplify list construction
                ListNode current = dummyHead;       // Pointer to build the result list
                int carry = 0;                      // Carry to handle sums greater than 9

                // Traverse both lists
                while (l1 != null || l2 != null)
                {
                    int x = (l1 != null) ? l1.val : 0; // Get the value from l1 or 0 if null
                    int y = (l2 != null) ? l2.val : 0; // Get the value from l2 or 0 if null

                    int sum = carry + x + y;          // Calculate the sum of the current digits
                    carry = sum / 10;                 // Update the carry for the next addition
                    current.next = new ListNode(sum % 10); // Create a new node with the digit value
                    current = current.next;          // Move to the next node

                    // Move to the next nodes in l1 and l2 if available
                    if (l1 != null) l1 = l1.next;
                    if (l2 != null) l2 = l2.next;
                }

                // If there's a carry left, add a new node with that value
                if (carry > 0)
                {
                    current.next = new ListNode(carry);
                }

                return dummyHead.next; // Return the result list starting after the dummy head
            }
        }

    }
}
