namespace LeetCode
{
    public class Solution32
    {
        public int LongestValidParentheses(string s)
        {
            int maxLength = 0;
            Stack<int> stack = new Stack<int>();

            // Initialize stack with a base value
            stack.Push(-1);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i); // Push index of '('
                }
                else
                {
                    stack.Pop(); // Pop the last unmatched '('
                    if (stack.Count == 0)
                    {
                        stack.Push(i); // Push current ')' index as a base for future calculations
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, i - stack.Peek());
                    }
                }
            }

            return maxLength;
        }
    }
}
