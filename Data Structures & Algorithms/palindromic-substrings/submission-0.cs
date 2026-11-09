public class Solution {
    public int CountSubstrings(string s) {
        int left = 0, right = 0, count = 0;

        for(int center = 0; center < s.Length; center++){
            left = center;
            right = center;

            while(left >= 0 && right < s.Length && s[left] == s[right]){
                left--;
                right++;
                count++;
            }
        }
        
        for(int center = 0; center < s.Length; center++){
            left = center;
            right = center + 1;

            while(left >= 0 && right < s.Length && s[left] == s[right]){
                left--;
                right++;
                count++;
            }
        }

        return count;
    }
}
