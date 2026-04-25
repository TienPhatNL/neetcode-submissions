public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;

        int maxLength = 0;
        int left = 0;
        Dictionary<char, int> di = new Dictionary<char, int>();

        for(int right = 0; right < s.Length; right++){
            char c = s[right];

            if(di.ContainsKey(c) && di[c] >= left ){
                left = di[c] + 1;
            }

            di[c] = right;

            int windowLength = right - left + 1;
            if(windowLength > maxLength){
                maxLength = windowLength;
            }
        }
        return maxLength;
    }
}
