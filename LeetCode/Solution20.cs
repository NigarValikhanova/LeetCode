namespace LeetCode
{
    public class Solution20
    {
        public bool IsValid(string s)
        {
            // Stack to keep track of opening brackets
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                // Push opening brackets onto the stack
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    // Check for matching closing brackets
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            // Ensure all brackets were matched
            return stack.Count == 0;
        }
    }
}
