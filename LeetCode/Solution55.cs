namespace LeetCode
{
    public class Solution55
    {
        public bool CanJump(int[] nums)
        {
            int maxReach = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxReach) return false; // If current index is unreachable, return false
                maxReach = Math.Max(maxReach, i + nums[i]); // Update max reachable index
                if (maxReach >= nums.Length - 1) return true; // If last index is reachable, return true
            }
            return false;
        }
    }

}
