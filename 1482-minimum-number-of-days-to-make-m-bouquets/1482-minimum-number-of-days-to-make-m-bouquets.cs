public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
       int n = bloomDay.Length;
       if((long) m* k > n)
         return -1;
        
        int low = bloomDay.Min();
        int high = bloomDay.Max();

        while(low<high)
        {
        int mid=low +(high-low)/2;
        int flowers=0;
        int bouquet=0;
        for(int i=0;i<n;i++ )
        {
            if(bloomDay[i]<=mid)
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

        if(bouquet>=m)
        {
            high=mid;
        }
        else
          low=mid+1;
        }

       return low;
    }
}