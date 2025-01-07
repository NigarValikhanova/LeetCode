namespace LeetCode
{
    public class Solution26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0; // Handle edge case where array is empty

            int k = 1; // Start at 1 since the first element is always unique

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                { // Check for a new unique element
                    nums[k] = nums[i]; // Place the unique element in the correct position
                    k++; // Increment the unique count
                }
            }

            return k; // Return the count of unique elements
        }
    }
}
