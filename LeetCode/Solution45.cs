public class Solution45
{
    public int Jump(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return 0; // If there's only one element, no jumps are needed.

        int jumps = 0;
        int currentEnd = 0;
        int farthest = 0;

        for (int i = 0; i < n - 1; i++)
        {
            // Update the farthest index we can reach so far.
            farthest = Math.Max(farthest, i + nums[i]);

            // If we've reached the end of the current range, we need to jump.
            if (i == currentEnd)
            {
                jumps++;
                currentEnd = farthest;

                // If the current end has reached or exceeded the last index, break.
                if (currentEnd >= n - 1)
                    break;
            }
        }

        return jumps;
    }
}
