namespace LeetCode
{
    public class Solution31
    {
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length;
            int i = n - 2;

            // Step 1: Find the first decreasing element from the end
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0) // If such an element exists
            {
                int j = n - 1;
                // Step 2: Find the element just larger than nums[i]
                while (nums[j] <= nums[i])
                {
                    j--;
                }

                // Step 3: Swap nums[i] and nums[j]
                Swap(nums, i, j);
            }

            // Step 4: Reverse the elements after index i
            Reverse(nums, i + 1, n - 1);
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
        }

    }
}
