using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution84
    {
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int index = 0;

            while (index < heights.Length)
            {
                // If the current bar is higher than the bar at the top of the stack, push it to the stack
                if (stack.Count == 0 || heights[index] >= heights[stack.Peek()])
                {
                    stack.Push(index++);
                }
                else
                {
                    // Calculate area with the top of the stack as the smallest bar
                    int top = stack.Pop();
                    int area = heights[top] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
                    maxArea = Math.Max(maxArea, area);
                }
            }

            // Calculate area for remaining bars in stack
            while (stack.Count > 0)
            {
                int top = stack.Pop();
                int area = heights[top] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
                maxArea = Math.Max(maxArea, area);
            }

            return maxArea;
        }
    }
}
