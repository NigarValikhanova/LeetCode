namespace LeetCode
{
    public class Solution77
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(result, new List<int>(), 1, n, k);
            return result;
        }

        private void Backtrack(IList<IList<int>> result, List<int> tempList, int start, int n, int k)
        {
            if (tempList.Count == k)
            {
                result.Add(new List<int>(tempList));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                tempList.Add(i);
                Backtrack(result, tempList, i + 1, n, k);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }

}
