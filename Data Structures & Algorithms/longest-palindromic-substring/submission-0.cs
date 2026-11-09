public class Solution {
    public string LongestPalindrome(string s) {
        int left = 0, right = 0, bestStart = 0, mLen = 0;

        for(int center = 0; center < s.Length; center++){
            left = center;
            right = center;

            while(left >= 0 && right < s.Length && s[left] == s[right]){
                int len = right - left + 1;
                if(len > mLen){
                    mLen = len;
                    bestStart = left;
                }
                left--;
                right++;
            }
        }

        for(int center = 0; center < s.Length; center++){
            left = center;
            right = center + 1;

            while(left >= 0 && right < s.Length && s[left] == s[right]){
                int len = right - left + 1;
                if(len > mLen){
                    mLen = len;
                    bestStart = left;
                }
                left--;
                right++;
            }
        }

        return s.Substring(bestStart, mLen);
    }
}
