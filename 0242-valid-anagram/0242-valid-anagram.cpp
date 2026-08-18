class Solution {
public:
    bool isAnagram(string s, string t) {
      if(s.size() != t.size())
      {
        return false;
      }  


      unordered_map<char,int>freqS;
      unordered_map<char,int>freqT;

      for(char ch:s)
      {
        freqS[ch]++;
      }

      for(char ch:t)
      {
        freqT[ch]++;
      }

     if( freqS == freqT )
     {
        return true;
     }

     return false;
    }
    
};