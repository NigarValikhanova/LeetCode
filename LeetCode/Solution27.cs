namespace LeetCode
{
    public class Solution27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0; // Counter for elements not equal to val

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i]; // Place the current element at the next position of k
                    k++; // Increment k
                }
            }

            return k; // Return the count of elements not equal to val
        }
    }
}
