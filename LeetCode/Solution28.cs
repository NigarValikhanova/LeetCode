namespace LeetCode
{
    public class Solution28
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0; // If needle is empty, return 0
            return haystack.IndexOf(needle); // Use IndexOf method to find the first occurrence
        }
    }
}
