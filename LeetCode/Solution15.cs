namespace LeetCode
{
    public class Solution15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums); // Sort the array to make it easier to avoid duplicates and use two pointers

            for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicate elements
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Move left and right pointers to avoid duplicates
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++; // Increase the sum by moving the left pointer to the right
                    }
                    else
                    {
                        right--; // Decrease the sum by moving the right pointer to the left
                    }
                }
            }

            return result;
        }

    }
}
