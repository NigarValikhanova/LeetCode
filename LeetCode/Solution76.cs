namespace LeetCode
{
    public class Solution76
    {
        public string MinWindow(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0) return "";

            Dictionary<char, int> targetCount = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (targetCount.ContainsKey(c))
                    targetCount[c]++;
                else
                    targetCount[c] = 1;
            }

            int left = 0, right = 0, minLength = int.MaxValue, minLeft = 0;
            int required = targetCount.Count;
            int formed = 0;
            Dictionary<char, int> windowCount = new Dictionary<char, int>();

            while (right < s.Length)
            {
                char c = s[right];
                if (windowCount.ContainsKey(c))
                    windowCount[c]++;
                else
                    windowCount[c] = 1;

                if (targetCount.ContainsKey(c) && windowCount[c] == targetCount[c])
                    formed++;

                while (left <= right && formed == required)
                {
                    char leftChar = s[left];
                    if (right - left + 1 < minLength)
                    {
                        minLength = right - left + 1;
                        minLeft = left;
                    }

                    windowCount[leftChar]--;
                    if (targetCount.ContainsKey(leftChar) && windowCount[leftChar] < targetCount[leftChar])
                        formed--;

                    left++;
                }
                right++;
            }

            return minLength == int.MaxValue ? "" : s.Substring(minLeft, minLength);
        }
    }

}
