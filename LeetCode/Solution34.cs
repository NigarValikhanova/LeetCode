public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = new int[] { -1, -1 };
        if (nums == null || nums.Length == 0)
            return result;

        // Find the first occurrence of the target
        result[0] = FindFirst(nums, target);

        // If the first occurrence is not found, return [-1, -1]
        if (result[0] == -1)
            return result;

        // Find the last occurrence of the target
        result[1] = FindLast(nums, target);

        return result;
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int first = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                first = mid;
                right = mid - 1; // Continue searching on the left side
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return first;
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int last = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                last = mid;
                left = mid + 1; // Continue searching on the right side
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return last;
    }
