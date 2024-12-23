namespace LeetCode
{
    public class Solution11
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                // Calculate the current area
                int currentHeight = Math.Min(height[left], height[right]);
                int currentWidth = right - left;
                int currentArea = currentHeight * currentWidth;

                // Update maxArea if the current area is greater
                maxArea = Math.Max(maxArea, currentArea);

                // Move the pointer corresponding to the shorter line inward
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
