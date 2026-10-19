class Solution {
public:
    bool uniqueOccurrences(vector<int>& arr) {
        unordered_map<int,int>freq;
        for(int a : arr)
        {
            freq[a]++;
        }

        unordered_set<int>seen;
        for(auto item :freq)
       {
         if(seen.count(item.second))
         {
          return false;
         }
       
          seen.insert(item.second);

       
       }
        return true;

    
      
    }
};