namespace LeetCode
{
    public class Solution80
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2) return nums.Length;

            int index = 2; // Start from the third element

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[index - 2])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
    }
}
