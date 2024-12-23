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

        #region LeetCode4

        Solution4 solution4 = new Solution4();

        // Test case 1
        int[] nums4 = { 1, 3 };
        int[] nums5 = { 2 };
        Console.WriteLine("Test Case 1: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 2.0

        // Test case 2
        nums1 = new int[] { 1, 2 };
        nums2 = new int[] { 3, 4 };
        Console.WriteLine("Test Case 2: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 2.5

        // Test case 3
        nums1 = new int[] { 0, 0 };
        nums2 = new int[] { 0, 0 };
        Console.WriteLine("Test Case 3: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 0.0

        // Test case 4
        nums1 = new int[] { 1 };
        nums2 = new int[] { 2, 3, 4 };
        Console.WriteLine("Test Case 4: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 2.0

        // Test case 5 (odd total length)
        nums1 = new int[] { 1, 2, 3 };
        nums2 = new int[] { 4, 5 };
        Console.WriteLine("Test Case 5: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 3.0

        // Test case 6 (empty array for nums1)
        nums1 = new int[] { };
        nums2 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Test Case 6: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 3.0

        // Test case 7 (empty array for nums2)
        nums1 = new int[] { 1, 2, 3, 4, 5 };
        nums2 = new int[] { };
        Console.WriteLine("Test Case 7: " + solution4.FindMedianSortedArrays(nums4, nums5)); // Output: 3.0

        #endregion

        #region LeetCode5
        Solution5 solution5 = new Solution5();
        Console.WriteLine(solution5.LongestPalindrome("babad")); // Output: "bab" or "aba"
        Console.WriteLine(solution5.LongestPalindrome("cbbd"));  // Output: "bb"
        #endregion

        #region LeetCode6

        Solution6 solution6 = new Solution6();

        // Example 1
        string s1 = "PAYPALISHIRING";
        int numRows1 = 3;
        Console.WriteLine(solution6.Convert(s1, numRows1)); // Output: "PAHNAPLSIIGYIR"

        // Example 2
        string s2 = "PAYPALISHIRING";
        int numRows2 = 4;
        Console.WriteLine(solution6.Convert(s2, numRows2)); // Output: "PINALSIGYAHRPI"

        // Example 3
        string s3 = "A";
        int numRows3 = 1;
        Console.WriteLine(solution6.Convert(s3, numRows3)); // Output: "A"

        #endregion

        #region LeetCode7

        Solution7 solution7 = new Solution7();

        Console.WriteLine(solution7.Reverse(123));   // Output: 321
        Console.WriteLine(solution7.Reverse(-123));  // Output: -321
        Console.WriteLine(solution7.Reverse(120));   // Output: 21

        #endregion

        #region LeetCode8

        Solution8 solution8 = new Solution8();

        Console.WriteLine(solution8.MyAtoi("42"));          // Output: 42
        Console.WriteLine(solution8.MyAtoi(" -042"));       // Output: -42
        Console.WriteLine(solution8.MyAtoi("1337c0d3"));    // Output: 1337
        Console.WriteLine(solution8.MyAtoi("0-1"));         // Output: 0
        Console.WriteLine(solution8.MyAtoi("words and 987")); // Output: 0

        #endregion

        #region LeetCode9

        Solution9 solution9 = new Solution9();

        // Test cases
        int[] testCases = { 121, -121, 10, 0, 12321, 123, -101, 1001, 1221, 1234321 };

        foreach (int testCase in testCases)
        {
            Console.WriteLine($"IsPalindrome({testCase}) = {solution9.IsPalindrome(testCase)}");
        }

        #endregion

        #region LeetCode10

        Solution10 solution10 = new Solution10();

        // Test cases
        var testCases10 = new (string s, string p, bool expected)[] {
            ("aa", "a", false),           // Single character cannot match multiple characters
            ("aa", "a*", true),          // '*' matches zero or more of the preceding character
            ("ab", ".*", true),          // '.' matches any character, '*' matches multiple
            ("aab", "c*a*b", true),      // 'c*' matches zero 'c', 'a*' matches two 'a's, 'b' matches
            ("mississippi", "mis*is*p*.", false), // Complex pattern with '*' and '.'
            ("", ".*", true),            // '.*' matches any string, including empty
            ("", "a*", true),            // '*' can match zero preceding characters
            ("", "", true),              // Empty string matches empty pattern
            ("ab", ".*c", false),        // '.' and '*' match 'ab', but no 'c' follows
            ("abc", "abc", true),        // Exact match
            ("aaa", "a*a", true),        // '*' matches zero or more of 'a', still matches
            ("a", "ab*", true),          // 'b*' matches zero 'b'
            ("abcd", "d*", false),       // Pattern 'd*' cannot match the start of 'abcd'
        };

        // Run test cases
        foreach (var (s, p, expected) in testCases10)
        {
            bool result10 = solution10.IsMatch(s, p);
            Console.WriteLine($"IsMatch(\"{s}\", \"{p}\") = {result}, Expected = {expected}, Passed = {result10 == expected}");
        }


        #endregion

        #region LeetCode11

        Solution11 solution11 = new Solution11();

        int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        Console.WriteLine("Max Area: " + solution11.MaxArea(height1)); // Output: 49

        int[] height2 = { 1, 1 };
        Console.WriteLine("Max Area: " + solution11.MaxArea(height2)); // Output: 1

        #endregion
    }
}


