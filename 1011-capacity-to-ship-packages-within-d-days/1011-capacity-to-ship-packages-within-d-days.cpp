class Solution {
public:
    int shipWithinDays(vector<int>& weights, int days) {
        int low=0;
        int high=0;
        for(int weight :weights)
        {
             low=max(low,weight);
            high += weight;
        }

        while(low<high)
        {
            int mid=low+(high-low)/2;
            int currentweight=0;
            int requiredDays= 1;
            for(int weight:weights)
            {
                if(weight + currentweight <= mid)
                {
                    currentweight += weight;
                }
                else
                {
                    requiredDays++;
                    currentweight=weight;
                }
            }

            if(requiredDays <= days)
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