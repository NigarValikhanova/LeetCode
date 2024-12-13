namespace LeetCode
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> complementMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (complementMap.ContainsKey(num))
                {
                    return new int[] { complementMap[num], i };
                }

                complementMap[target - num] = i;
            }

            return new int[0];
        }
    }
}
