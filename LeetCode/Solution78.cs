using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution78
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            GenerateSubsets(nums, 0, new List<int>(), result);
            return result;
        }

        private void GenerateSubsets(int[] nums, int index, List<int> current, IList<IList<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = index; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                GenerateSubsets(nums, i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
