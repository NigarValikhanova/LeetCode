﻿using LeetCode;
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

        #region LeetCode12

        Solution12 solution12 = new Solution12();

        Console.WriteLine(solution12.IntToRoman(3749)); // Output: "MMMDCCXLIX"
        Console.WriteLine(solution12.IntToRoman(58));   // Output: "LVIII"
        Console.WriteLine(solution12.IntToRoman(1994)); // Output: "MCMXCIV"

        #endregion

        #region LeetCode13

        Solution13 solution13 = new Solution13();

        Console.WriteLine("Enter a Roman numeral:");
        string input = Console.ReadLine();
        int result13 = solution13.RomanToInt(input);
        Console.WriteLine($"The integer value of {input} is: {result13}");


        #endregion

        #region LeetCode14

        Solution14 solution14 = new Solution14();

        string[] example14 = { "flower", "flow", "flight" };
        string result14 = solution14.LongestCommonPrefix(example14);
        Console.WriteLine(result14); // Output: "fl"

        string[] example12 = { "dog", "racecar", "car" };
        string result12 = solution14.LongestCommonPrefix(example12);
        Console.WriteLine(result12); // Output: ""

        #endregion

        #region LeetCode15

        Solution15 solution15 = new Solution15();

        int[] nums15 = { -1, 0, 1, 2, -1, -4 };
        Console.WriteLine("Example 1:");
        PrintResult(solution15.ThreeSum(nums15));

        int[] nums152 = { 0, 1, 1 };
        Console.WriteLine("Example 2:");
        PrintResult(solution15.ThreeSum(nums152));

        int[] nums153 = { 0, 0, 0 };
        Console.WriteLine("Example 3:");
        PrintResult(solution15.ThreeSum(nums153));

        #endregion

        #region LeetCode16

        Solution16 solution16 = new Solution16();

        // Example 1
        int[] nums16 = { -1, 2, 1, -4 };
        int target16 = 1;
        Console.WriteLine(solution16.ThreeSumClosest(nums16, target16)); // Output: 2

        // Example 2
        int[] nums162 = { 0, 0, 0 };
        int target162 = 1;
        Console.WriteLine(solution16.ThreeSumClosest(nums162, target162)); // Output: 0


        #endregion

        #region LeetCode17

        Solution17 solution17 = new Solution17();

        Console.WriteLine("Example 1:");
        var output1 = solution17.LetterCombinations("23");
        Console.WriteLine(string.Join(", ", output1));

        Console.WriteLine("\nExample 2:");
        var output2 = solution17.LetterCombinations("");
        Console.WriteLine(string.Join(", ", output2));

        Console.WriteLine("\nExample 3:");
        var output3 = solution17.LetterCombinations("2");
        Console.WriteLine(string.Join(", ", output3));


        #endregion

        #region LeetCode18

        var solution18 = new Solution18();
        int[] nums18 = { 1, 0, -1, 0, -2, 2 };
        int target18 = 0;
        var result18 = solution18.FourSum(nums18, target18);
        Console.WriteLine("Example 1 Result:");
        foreach (var quad in result18)
        {
            Console.WriteLine(string.Join(",", quad));
        }

        int[] nums182 = { 2, 2, 2, 2, 2 };
        int target182 = 8;
        var result182 = solution18.FourSum(nums182, target182);
        Console.WriteLine("\nExample 2 Result:");
        foreach (var quad in result182)
        {
            Console.WriteLine(string.Join(",", quad));
        }
        #endregion

        #region LeetCode19

        void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " -> ");
                node = node.next;
            }
            Console.WriteLine("null");
        }


        Solution19 solution19 = new Solution19();

        // Example 1
        ListNode head19_1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        int n1 = 2;
        Console.WriteLine("Example 1:");
        PrintList(solution19.RemoveNthFromEnd(head19_1, n1));

        // Example 2
        ListNode head19_2 = new ListNode(1);
        int n2 = 1;
        Console.WriteLine("Example 2:");
        PrintList(solution19.RemoveNthFromEnd(head19_2, n2));

        // Example 3
        ListNode head19_3 = new ListNode(1, new ListNode(2));
        int n3 = 1;
        Console.WriteLine("Example 3:");
        PrintList(solution19.RemoveNthFromEnd(head19_3, n3));

        #endregion

        #region LeetCode20

        Solution20 solution20 = new Solution20();

        Console.WriteLine(solution20.IsValid("()"));       // Output: true
        Console.WriteLine(solution20.IsValid("()[]{}"));  // Output: true
        Console.WriteLine(solution20.IsValid("(]"));      // Output: false
        Console.WriteLine(solution20.IsValid("([])"));    // Output: true

        #endregion

        #region LeetCode21

        Solution21 solution21 = new Solution21();

        // Example 1
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode merged = solution21.MergeTwoLists(list1, list2);
        PrintList(merged); // Output: 1 -> 1 -> 2 -> 3 -> 4 -> 4

        // Example 2
        ListNode empty1 = null;
        ListNode empty2 = null;
        merged = solution21.MergeTwoLists(empty1, empty2);
        PrintList(merged); // Output: (empty)

        // Example 3
        ListNode single = new ListNode(0);
        merged = solution21.MergeTwoLists(null, single);
        PrintList(merged); // Output: 0

        #endregion

        #region LeetCode22

        Solution22 solution22 = new Solution22();
        int n = 3;
        IList<string> result22 = solution22.GenerateParenthesis(n);
        Console.WriteLine(string.Join(", ", result22));

        #endregion

        #region LeetCode23

        // Create test cases
        ListNode[] lists = new ListNode[] {
            CreateLinkedList(new int[] { 1, 4, 5 }),
            CreateLinkedList(new int[] { 1, 3, 4 }),
            CreateLinkedList(new int[] { 2, 6 })
        };

        // Create solution object
        Solution23 solution23 = new Solution23();

        // Run the MergeKLists method
        ListNode result23 = solution23.MergeKLists(lists);

        // Print the merged linked list
        PrintLinkedList(result);

        // Additional test cases
        Console.WriteLine("Test Case 2: Empty list of lists");
        ListNode[] emptyLists = new ListNode[] { };
        result23 = solution23.MergeKLists(emptyLists);
        PrintLinkedList(result); // Expected: (empty output)

        Console.WriteLine("Test Case 3: Single empty list");
        ListNode[] singleEmptyList = new ListNode[] { null };
        result23 = solution23.MergeKLists(singleEmptyList);
        PrintLinkedList(result); // Expected: (empty output)

        #endregion

        #region LeetCode24

        // Example 1: Input: [1, 2, 3, 4]
        int[] input24 = { 1, 2, 3, 4 };
        ListNode head24 = CreateLinkedList(input24);

        Solution24 solution24 = new Solution24();
        ListNode swappedHead = solution24.SwapPairs(head24);

        Console.WriteLine("Example 1:");
        PrintLinkedList(swappedHead);

        #endregion

        #region LeetCode25

        // Create a sample linked list: 1 -> 2 -> 3 -> 4 -> 5
        ListNode head25 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        // Set the value of k
        int k = 2;

        // Create a Solution instance and call ReverseKGroup
        Solution25 solution25 = new Solution25();
        ListNode result25 = solution25.ReverseKGroup(head25, k);

        // Print the result
        PrintList(result);

        #endregion

        #region LeetCode26

        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Instantiate the solution class and call the method
        Solution26 solution26 = new Solution26();
        int k26 = solution26.RemoveDuplicates(nums);

        // Print the number of unique elements
        Console.WriteLine("Number of unique elements: " + k26);

        // Print the modified array
        Console.WriteLine("Modified array with unique elements:");
        for (int i = 0; i < k26; i++)
        {
            Console.Write(nums[i] + " ");
        }

        #endregion

        #region LeetCode27

        int[] nums27 = { 3, 2, 2, 3 };
        int val27 = 3;
        Solution27 solution27 = new Solution27();
        int result27 = solution27.RemoveElement(nums27, val27);
        Console.WriteLine($"Result: {result27}, Updated Array: [{string.Join(", ", nums27[..result27])}]");

        #endregion

        #region LeetCode28

        Solution28 solution28 = new Solution28();

        // Example 1
        string haystack28 = "sadbutsad";
        string needle28 = "sad";
        Console.WriteLine(solution28.StrStr(haystack28, needle28)); // Output: 0

        #endregion

        #region LeetCode29

        Solution29 solution29 = new Solution29();

        Console.WriteLine(solution29.Divide(10, 3)); // Output: 3
        Console.WriteLine(solution29.Divide(7, -3)); // Output: -2
        Console.WriteLine(solution29.Divide(int.MinValue, -1)); // Output: 2147483647 (int.MaxValue)

        #endregion

        #region LeetCode30

        Solution30 solution30 = new Solution30();

        // Example 1
        string s30 = "barfoothefoobarman";
        string[] words30 = { "foo", "bar" };
        var result30 = solution30.FindSubstring(s30, words30);
        Console.WriteLine(string.Join(", ", result30)); // Output: [0, 9]

        #endregion

        #region LeetCode31

        Solution31 solution31 = new Solution31();

        int[] nums31 = { 1, 2, 3 };
        solution31.NextPermutation(nums31);
        Console.WriteLine(string.Join(", ", nums31)); // Output: 1, 3, 2

        int[] nums312 = { 3, 2, 1 };
        solution31.NextPermutation(nums312);
        Console.WriteLine(string.Join(", ", nums312)); // Output: 1, 2, 3

        int[] nums313 = { 1, 1, 5 };
        solution31.NextPermutation(nums313);
        Console.WriteLine(string.Join(", ", nums313)); // Output: 1, 5, 1

        #endregion

        #region LeetCode32

        Solution32 solution32 = new Solution32();

        Console.WriteLine(solution32.LongestValidParentheses("(()")); // Output: 2
        Console.WriteLine(solution32.LongestValidParentheses(")()())")); // Output: 4
        Console.WriteLine(solution32.LongestValidParentheses("")); // Output: 0

        #endregion

        #region LeetCode33

        int[] nums33 = { 4, 5, 6, 7, 0, 1, 2 };
        int target33 = 0;

        Solution33 solution33 = new Solution33();
        int result33 = solution33.Search(nums33, target33);
        Console.WriteLine(result33); // Output: 4


        #endregion

        #region LeetCode41

        int[] nums41 = { 3, 4, -1, 1 };
        int[] nums413 = { 7, 8, 9, 11, 12 };

        Solution41 solution41 = new Solution41();

        Console.WriteLine("Example 1:");
        Console.WriteLine("Input: [3, 4, -1, 1]");
        Console.WriteLine("Output: " + solution41.FirstMissingPositive(nums41)); // Expected output: 2

        Console.WriteLine("\nExample 2:");
        Console.WriteLine("Input: [7, 8, 9, 11, 12]");
        Console.WriteLine("Output: " + solution41.FirstMissingPositive(nums413)); // Expected output: 1

        #endregion

        #region LeetCode42

        Solution42 solution42 = new Solution42();

        // Example 1
        int[] height42 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        Console.WriteLine("Water trapped: " + solution42.Trap(height42)); // Output: 6

        // Example 2
        int[] height422 = { 4, 2, 0, 3, 2, 5 };
        Console.WriteLine("Water trapped: " + solution42.Trap(height422)); // Output: 9

        #endregion

        #region LeetCode43

        Solution43 solution43 = new Solution43();
        string num43 = "123";
        string num432 = "456";
        string result43 = solution43.Multiply(num43, num432);
        Console.WriteLine($"The product of {num43} and {num432} is: {result43}");

        #endregion

        #region LeetCode44



        #endregion

        #region LeetCode45

        Solution45 solution45 = new Solution45();

        int[] nums45 = { 2, 3, 1, 1, 4 };
        Console.WriteLine(solution45.Jump(nums45)); // Output: 2

        #endregion

        #region LeetCode46

        Solution46 solution46 = new Solution46();

        int[] nums461 = { 1, 2, 3 };
        Console.WriteLine("Permutations of [1, 2, 3]:");
        PrintResult(solution46.Permute(nums461));

        int[] nums462 = { 0, 1 };
        Console.WriteLine("\nPermutations of [0, 1]:");
        PrintResult(solution46.Permute(nums462));

        #endregion

        #region LeetCode47

        Solution47 solution47 = new Solution47();
        var nums471 = new int[] { 1, 1, 2 };
        var result471 = solution47.PermuteUnique(nums471);
        Console.WriteLine("Unique permutations for [1, 1, 2]:");
        foreach (var perm in result471)
        {
            Console.WriteLine("[" + string.Join(", ", perm) + "]");
        }

        var nums472 = new int[] { 1, 2, 3 };
        var result472 = solution47.PermuteUnique(nums472);
        Console.WriteLine("Unique permutations for [1, 2, 3]:");
        foreach (var perm in result472)
        {
            Console.WriteLine("[" + string.Join(", ", perm) + "]");
        }

        #endregion

        #region LeetCode48

        int[][] matrix = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        Solution48 solution48 = new Solution48();
        solution48.Rotate(matrix);

        Console.WriteLine("Rotated Matrix:");
        PrintMatrix(matrix);

        #endregion

        #region LeetCode49

        Solution49 solution49 = new Solution49();
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result49 = solution49.GroupAnagrams(strs);

        foreach (var group in result49)
        {
            Console.WriteLine("[" + string.Join(", ", group) + "]");
        }
        #endregion

        #region LeetCode50

        Solution50 solution50 = new Solution50();
        Console.WriteLine(solution50.MyPow(2.00000, 10)); // Output: 1024.00000
        Console.WriteLine(solution50.MyPow(2.10000, 3));  // Output: 9.26100
        Console.WriteLine(solution50.MyPow(2.00000, -2)); // Output: 0.25000

        #endregion

        #region LeetCode51

        int n51 = 4;
        Solution51 solution51 = new Solution51();
        var solutions = solution51.SolveNQueens(n51);

        foreach (var solver in solutions)
        {
            foreach (var row in solver)
            {
                Console.WriteLine(row);
            }
            Console.WriteLine();
        }

        #endregion

        #region LeetCode52


        Solution52 solution52 = new Solution52();
        int n52 = 4;
        Console.WriteLine("Number of solutions for " + n52 + "-queens: " + solution52.TotalNQueens(n52));

        #endregion

        #region LeetCode53

        Solution53 solution53 = new Solution53();

        int[] nums531 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(solution53.MaxSubArray(nums531)); // Output: 6

        int[] nums532 = { 1 };
        Console.WriteLine(solution53.MaxSubArray(nums532)); // Output: 1

        int[] nums533 = { 5, 4, -1, 7, 8 };
        Console.WriteLine(solution53.MaxSubArray(nums533)); // Output: 23

        #endregion

        #region LeetCode54

        Solution54 solution54 = new Solution54();
        int[][] matrix541 = new int[][] {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        Console.WriteLine(string.Join(", ", solution54.SpiralOrder(matrix541)));

        int[][] matrix542 = new int[][] {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12}
        };
        Console.WriteLine(string.Join(", ", solution54.SpiralOrder(matrix542)));

        #endregion

        #region LeetCode55

        Solution55 solution55 = new Solution55();

        int[] nums551 = { 2, 3, 1, 1, 4 };
        Console.WriteLine(solution55.CanJump(nums551)); // Output: True

        int[] nums552 = { 3, 2, 1, 0, 4 };
        Console.WriteLine(solution55.CanJump(nums552)); // Output: False

        #endregion

        #region LeetCode56

        Solution56 solution56 = new Solution56();

        int[][] intervals56 = new int[][]
        {
            new int[] {1, 3},
            new int[] {2, 6},
            new int[] {8, 10},
            new int[] {15, 18}
        };

        int[][] mergedIntervals56 = solution56.Merge(intervals56);

        Console.WriteLine("Merged Intervals:");
        foreach (var interval in mergedIntervals56)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
        #endregion

        #region LeetCode57

        Solution57 solution57 = new Solution57();

        int[][] intervals571 = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };
        int[] newInterval571 = new int[] { 2, 5 };

        int[][] result571 = solution57.Insert(intervals571, newInterval571);
        PrintIntervals57(result571); // Output: [[1,5],[6,9]]

        int[][] intervals572 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
        int[] newInterval572 = new int[] { 4, 8 };

        int[][] result572 = solution57.Insert(intervals572, newInterval572);
        PrintIntervals57(result572); // Output: [[1,2],[3,10],[12,16]]

        #endregion

    }

    #region LeetCode15 Method
    private static void PrintResult(IList<IList<int>> result)
    {
        foreach (var triplet in result)
        {
            Console.WriteLine("[" + string.Join(", ", triplet) + "]");
        }
    }

    #endregion

    #region LeetCode23 Method

    // Helper method to create a linked list from an array
    public static ListNode CreateLinkedList(int[] values)
    {
        if (values == null || values.Length == 0) return null;
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    // Helper method to print a linked list
    public static void PrintLinkedList(ListNode head)
    {
        if (head == null)
        {
            Console.WriteLine("(empty)");
            return;
        }
        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");
    }

    #endregion

    #region LeetCode48 Method

    static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
        Console.WriteLine();
    }
    #endregion

    #region LeetCode57 Method

    static void PrintIntervals57(int[][] intervals)
    {
        Console.Write("[");
        for (int i = 0; i < intervals.Length; i++)
        {
            Console.Write($"[{intervals[i][0]},{intervals[i][1]}]");
            if (i < intervals.Length - 1) Console.Write(",");
        }
        Console.WriteLine("]");

    }
    #endregion
}

