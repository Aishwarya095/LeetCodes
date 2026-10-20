class Solution {
public:
    int minDays(vector<int>& bloomDay, int m, int k) {
        if ((long long)m * k > bloomDay.size())
            return -1;
        int n=bloomDay.size();

        int low= *min_element(bloomDay.begin(),bloomDay.end()); 
        int high= *max_element(bloomDay.begin(),bloomDay.end()); 

        while(low<high)
        {
        int mid=low+(high-low)/2;
        int flowers=0;
        int bouquet=0;
        for(int i=0;i<n;i++)
        {
            if(bloomDay[i] <= mid)
            {
               flowers++;

               if(flowers ==k)
               {
                bouquet++;
                flowers=0;
               }
            }
            else{
                flowers=0;
            }

          
        }

        if(bouquet >=m)
        {
            high=mid;
        }
        else
          low=mid+1;
        }

       return low;
    }
};