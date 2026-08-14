class Solution {
public:
    int maxArea(vector<int>& height) {
       int left=0;
       int right=height.size()-1;
       int mostWater=0;

       while(left < right)
       {
        int width=right-left;
        int maxheight=min(height[left],height[right]);
        int area=width*maxheight;
         mostWater = max(mostWater,area);



        if(height[left] <=height[right])
          left++;

        else 
          right--;

       }
    return mostWater;
        
    }
};