namespace LeetCode
{
    public class Solution40
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> currentCombination = new List<int>();
            Array.Sort(candidates); // Sort the array to handle duplicates
            Backtrack(candidates, target, 0, currentCombination, result);
            return result;
        }

        private void Backtrack(int[] candidates, int target, int start, List<int> currentCombination, List<IList<int>> result)
        {
            // If the target is 0, we've found a valid combination
            if (target == 0)
            {
                result.Add(new List<int>(currentCombination)); // Add a copy of the current combination
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                // Skip duplicates
                if (i > start && candidates[i] == candidates[i - 1]) continue;

                // If the current number exceeds the target, break (because the array is sorted)
                if (candidates[i] > target) break;

                // Include candidates[i] in the current combination
                currentCombination.Add(candidates[i]);

                // Recur with the remaining target and the next element (i + 1), ensuring candidates[i] can only be used once
                Backtrack(candidates, target - candidates[i], i + 1, currentCombination, result);

                // Backtrack, remove the last added element
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
