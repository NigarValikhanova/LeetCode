using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution90
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums); // Sort to handle duplicates
            List<IList<int>> result = new List<IList<int>>();
            Backtrack(nums, 0, new List<int>(), result);
            return result;
        }

        private void Backtrack(int[] nums, int start, List<int> current, List<IList<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue; // Skip duplicates

                current.Add(nums[i]);
                Backtrack(nums, i + 1, current, result);
                current.RemoveAt(current.Count - 1); // Backtrack
            }
        }
    }
}
