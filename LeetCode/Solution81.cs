namespace LeetCode
{
    public class Solution81
    {
        public bool Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target) return true;

                // Handle duplicates: If left, mid, and right are the same, shrink the search space
                if (nums[left] == nums[mid] && nums[mid] == nums[right])
                {
                    left++;
                    right--;
                }
                // Left half is sorted
                else if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                // Right half is sorted
                else
                {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return false;
        }
    }
}
