namespace LeetCode
{
    public class Solution56
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0) return new int[0][];

            // Sort intervals by the start value
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> merged = new List<int[]>();

            foreach (var interval in intervals)
            {
                // If merged list is empty or the current interval does not overlap, add it
                if (merged.Count == 0 || merged.Last()[1] < interval[0])
                {
                    merged.Add(interval);
                }
                else
                {
                    // Otherwise, merge the intervals
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }

            return merged.ToArray();
        }
    }

}
