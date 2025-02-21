namespace LeetCode
{
    public class Solution71
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            string[] parts = path.Split('/');

            foreach (string part in parts)
            {
                if (part == "..")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else if (!string.IsNullOrEmpty(part) && part != ".")
                {
                    stack.Push(part);
                }
            }

            return "/" + string.Join("/", stack.ToArray().Reverse());
        }
    }
}
