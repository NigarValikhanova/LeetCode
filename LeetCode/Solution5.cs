namespace LeetCode
{
    public class Solution5
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1)
                return "";

            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Check for palindrome with single character center
                int len1 = ExpandAroundCenter(s, i, i);

                // Check for palindrome with two characters as center
                int len2 = ExpandAroundCenter(s, i, i + 1);

                // Get the longer of the two
                int len = Math.Max(len1, len2);

                // Update start and end indexes for the longest palindrome found
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1; // Length of the palindrome
        }
    }

}
