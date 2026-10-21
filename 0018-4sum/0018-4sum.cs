using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        int n = nums.Length;

        Array.Sort(nums);

        for (int i = 0; i < n - 3; i++)
        {
            // Skip duplicate i values
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            for (int j = i + 1; j < n - 2; j++)
            {
                // Skip duplicate j values
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                int left = j + 1;
                int right = n - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j]
                             + nums[left] + nums[right];

                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        answer.Add(new List<int>
                        {
                            nums[i], nums[j], nums[left], nums[right]
                        });

                        left++;
                        right--;

                        // Skip duplicate left values
                        while (left < right &&
                               nums[left] == nums[left - 1])
                        {
                            left++;
                        }

                        // Skip duplicate right values
                        while (left < right &&
                               nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                }
            }
        }

        return answer;
    }
}