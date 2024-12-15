using LeetCode;
using static LeetCode.Solution2;

public class Program
{
    public static void Main()
    {
        #region LeetCode1
        Solution1 solution = new Solution1();

        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        Console.WriteLine(string.Join(", ", solution.TwoSum(nums1, target1))); // Output: 0, 1

        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        Console.WriteLine(string.Join(", ", solution.TwoSum(nums2, target2))); // Output: 1, 2

        int[] nums3 = { 3, 3 };
        int target3 = 6;
        Console.WriteLine(string.Join(", ", solution.TwoSum(nums3, target3))); // Output: 0, 1

        #endregion

        #region LeetCode2

        // Create instances of the ListNode and test cases
        Solution2.Solution solution2 = new Solution2.Solution();

        // Example 1: l1 = [2,4,3], l2 = [5,6,4]
        Solution2.ListNode l1 = ConvertArrayToLinkedList(new int[] { 2, 4, 3 });
        Solution2.ListNode l2 = ConvertArrayToLinkedList(new int[] { 5, 6, 4 });

        Solution2.ListNode result = solution2.AddTwoNumbers(l1, l2);

        Console.WriteLine("Example 1: ");
        Console.WriteLine("Input L1: " + LinkedListToString(l1));
        Console.WriteLine("Input L2: " + LinkedListToString(l2));
        Console.WriteLine("Result: " + LinkedListToString(result));
        Console.WriteLine();

        // Example 2: l1 = [0], l2 = [0]
        l1 = ConvertArrayToLinkedList(new int[] { 0 });
        l2 = ConvertArrayToLinkedList(new int[] { 0 });

        result = solution2.AddTwoNumbers(l1, l2);

        Console.WriteLine("Example 2: ");
        Console.WriteLine("Input L1: " + LinkedListToString(l1));
        Console.WriteLine("Input L2: " + LinkedListToString(l2));
        Console.WriteLine("Result: " + LinkedListToString(result));
        Console.WriteLine();

        // Example 3: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        l1 = ConvertArrayToLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        l2 = ConvertArrayToLinkedList(new int[] { 9, 9, 9, 9 });

        result = solution2.AddTwoNumbers(l1, l2);

        Console.WriteLine("Example 3: ");
        Console.WriteLine("Input L1: " + LinkedListToString(l1));
        Console.WriteLine("Input L2: " + LinkedListToString(l2));
        Console.WriteLine("Result: " + LinkedListToString(result));
        Console.WriteLine();
    

        // Utility to convert an array to a linked list
        static Solution2.ListNode ConvertArrayToLinkedList(int[] arr)
        {
            Solution2.ListNode dummyHead = new Solution2.ListNode(0);
            Solution2.ListNode current = dummyHead;
            foreach (int val in arr)
            {
                current.next = new Solution2.ListNode(val);
                current = current.next;
            }
            return dummyHead.next;
        }

        // Utility to print a linked list as a string
        static string LinkedListToString(Solution2.ListNode node)
        {
            if (node == null) return "null";
            var result = new System.Text.StringBuilder();
            while (node != null)
            {
                result.Append(node.val);
                if (node.next != null) result.Append(" -> ");
                node = node.next;
            }
            return result.ToString();
        }

        #endregion


        #region LeetCode3
        Solution3 solution3 = new Solution3();

        // Test cases
        Console.WriteLine(solution3.LengthOfLongestSubstring("abcabcbb")); // Expected: 3
        Console.WriteLine(solution3.LengthOfLongestSubstring("bbbbb"));    // Expected: 1
        Console.WriteLine(solution3.LengthOfLongestSubstring("pwwkew"));   // Expected: 3
        Console.WriteLine(solution3.LengthOfLongestSubstring(""));         // Expected: 0
        Console.WriteLine(solution3.LengthOfLongestSubstring(" "));        // Expected: 1
        Console.WriteLine(solution3.LengthOfLongestSubstring("au"));       // Expected: 2
        Console.WriteLine(solution3.LengthOfLongestSubstring("dvdf"));     // Expected: 3
        #endregion
    }
}
