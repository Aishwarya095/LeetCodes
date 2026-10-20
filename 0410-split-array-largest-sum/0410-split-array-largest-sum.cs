public class Solution {
    public int SplitArray(int[] nums, int k) {
      int low=0;
      int high=0;
      foreach(int num in nums)
      {
        low=Math.Max(low,num);
        high += num;
       }
       while(low < high)
       {
        int mid=low+(high-low)/2;
        int subarrays=1;
        int currentsum=0;
        foreach(int num in nums)
        {
            if(currentsum + num <=mid)
            {
                currentsum += num;
            }
            else
            {
                subarrays++;
                currentsum = num;
            }
        }

        if(subarrays <= k)
        {
            high=mid;
        }
        else
         {
            low=mid+1;
         }
       }

       return low;  
    }

    
}