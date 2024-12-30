using System;
using System.Collections.Generic;

public class Solution18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);  // Sort the array to facilitate skipping duplicates.
        var result = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length - 3; i++)
        {
            // Skip duplicate elements for the first number
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                // Skip duplicate elements for the second number
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                int left = j + 1;
                int right = nums.Length - 1;
                
                while (left < right)
                {
                    int sum = nums[i] + nums[j] + nums[left] + nums[right];
                    
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        
                        // Skip duplicate elements for the third and fourth numbers
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;
                        
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
