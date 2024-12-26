namespace LeetCode
{
    public class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            // Start with the first string as the prefix
            string prefix = strs[0];

            // Compare the prefix with each string in the array
            for (int i = 1; i < strs.Length; i++)
            {
                // Reduce the prefix length until it matches the start of the current string
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If the prefix becomes empty, there is no common prefix
                    if (prefix == "")
                        return "";
                }
            }

            return prefix;
        }
    }

}
