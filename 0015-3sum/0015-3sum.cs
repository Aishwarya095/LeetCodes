public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
     
         IList<IList<int>> answer = new List<IList<int>>(); 

  

        int n = nums.Length; 

        Array.Sort(nums); 

  

        for (int i = 0; i < n - 2; i++) 

        { 

            // Skip duplicate values of i 

            if (i > 0 && nums[i] == nums[i - 1]) 

                continue; 

  

            int left = i + 1; 

            int right = n - 1; 

  

            while (left < right) 

            { 

                int sum = nums[i] + nums[left] + nums[right]; 

  

                if (sum < 0) 

                { 

                    left++; 

                } 

                else if (sum > 0) 

                { 

                    right--; 

                } 

                else 

                { 

                    answer.Add(new List<int> 

                    { 

                        nums[i], nums[left], nums[right] 

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

  

        return answer; 

    } 

} 
  
