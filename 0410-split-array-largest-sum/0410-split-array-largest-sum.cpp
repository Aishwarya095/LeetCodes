class Solution {
public:
    int splitArray(vector<int>& nums, int k) {
      int low=0;
      int high=0;
      for(int num : nums)
      {
        low=max(low,num);
        high += num;
       }
       while(low < high)
       {
        int mid=low+(high-low)/2;
        int subarrays=1;
        int currentsum=0;
        for(int num :nums)
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

    
};