namespace LeetCode
{
    public class Solution57
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            int i = 0;
            int n = intervals.Length;

            // Add all intervals that end before the new interval starts
            while (i < n && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                i++;
            }

            // Merge overlapping intervals
            while (i < n && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            result.Add(newInterval);

            // Add remaining intervals
            while (i < n)
            {
                result.Add(intervals[i]);
                i++;
            }

            return result.ToArray(); // Convert List<int[]> to int[][]
        }
    }

}
