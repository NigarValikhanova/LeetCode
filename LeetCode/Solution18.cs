public class Solution18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums); // Sort the array to simplify handling duplicates
        var result = new List<IList<int>>();
        int n = nums.Length;

        for (int i = 0; i < n - 3; i++)
        {
            // Avoid duplicates for the first element
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < n - 2; j++)
            {
                // Avoid duplicates for the second element
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                int left = j + 1;
                int right = n - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                        // Move left and right pointers to avoid duplicates
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
