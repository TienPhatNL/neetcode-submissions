public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s)) return false;
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        s = s.Trim().ToLower();
        var right = s.Length - 1;
        
        for(int left = 0; left < s.Length; left++){
            if(s[left] != s[right]) return false;
            right--;
        }
        return true;
    }
}
