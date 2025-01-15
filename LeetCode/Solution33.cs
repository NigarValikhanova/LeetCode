public class Solution33 {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            // Check if the mid element is the target
            if (nums[mid] == target)
                return mid;

            // Determine which side is sorted
            if (nums[left] <= nums[mid]) {
                // Left side is sorted
                if (nums[left] <= target && target < nums[mid]) {
                    // Target is in the left sorted part
                    right = mid - 1;
                } else {
                    // Target is in the unsorted part
                    left = mid + 1;
                }
            } else {
                // Right side is sorted
                if (nums[mid] < target && target <= nums[right]) {
                    // Target is in the right sorted part
                    left = mid + 1;
                } else {
                    // Target is in the unsorted part
                    right = mid - 1;
                }
            }
        }

        // Target not found
        return -1;
    }
}
