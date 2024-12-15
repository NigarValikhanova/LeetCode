namespace LeetCode
{
    public class Solution3
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int start = 0, maxLength = 0;

            for (int end = 0; end < s.Length; end++)
            {
                while (charSet.Contains(s[end]))
                {
                    charSet.Remove(s[start]);
                    start++;
                }
                charSet.Add(s[end]);
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }
    }
}
