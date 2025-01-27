namespace LeetCode
{
    public class Solution46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            Backtrack(nums, new List<int>(), result);
            return result;
        }

        private void Backtrack(int[] nums, List<int> current, IList<IList<int>> result)
        {
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (current.Contains(nums[i])) continue; // Skip already used numbers
                current.Add(nums[i]);
                Backtrack(nums, current, result);
                current.RemoveAt(current.Count - 1); // Remove the last element to backtrack
            }
        }
    }
}
