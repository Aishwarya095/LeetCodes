class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int miniPrice= prices[0];
        int maxPrice=0;

        for(int i=0;i<prices.size();i++)
        {
            miniPrice=min(miniPrice,prices[i]);

            int profit =prices[i] - miniPrice;

            maxPrice = max(maxPrice,profit);
        }

        return maxPrice;
    }
};