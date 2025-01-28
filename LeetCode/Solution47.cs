namespace LeetCode
{
    public class Solution47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var results = new List<IList<int>>();
            Array.Sort(nums); // Sort to handle duplicates
            Backtrack(nums, new bool[nums.Length], new List<int>(), results);
            return results;
        }

        private void Backtrack(int[] nums, bool[] used, List<int> current, List<IList<int>> results)
        {
            if (current.Count == nums.Length)
            {
                results.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue; // Skip if already used

                // Skip duplicates
                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                    continue;

                used[i] = true;
                current.Add(nums[i]);
                Backtrack(nums, used, current, results);
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
