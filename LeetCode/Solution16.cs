namespace LeetCode
{
    public class Solution16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums); // Sort the array
            int closestSum = nums[0] + nums[1] + nums[2]; // Initialize with the first three elements

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];

                    // Update closestSum if the current sum is closer to the target
                    if (Math.Abs(target - currentSum) < Math.Abs(target - closestSum))
                    {
                        closestSum = currentSum;
                    }

                    if (currentSum < target)
                    {
                        left++; // Move the left pointer to increase the sum
                    }
                    else if (currentSum > target)
                    {
                        right--; // Move the right pointer to decrease the sum
                    }
                    else
                    {
                        // If the current sum equals the target, it's the closest possible sum
                        return currentSum;
                    }
                }
            }

            return closestSum;
        }
    }
}
