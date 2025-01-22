namespace LeetCode
{
    public class Solution41
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Place each number in its correct position
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    Swap(nums, i, nums[i] - 1);
                }
            }

            // Step 2: Find the first index where the value is not correct
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            // If all numbers are in place, return n + 1
            return n + 1;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
