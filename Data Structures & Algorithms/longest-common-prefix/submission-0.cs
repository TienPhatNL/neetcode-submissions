public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var prefix = new StringBuilder();
        bool isValid  = true;

        for(int i = 0; i < strs[0].Length; i ++){
            for(int j = 0; j < strs.Length; j ++){
                if(strs[j].Length <= i || strs[j][i] != strs[0][i]){
                    isValid = false;
                    break;
                };
            }
            if(!isValid) break;
            prefix.Append(strs[0][i]);
        }
        return prefix.ToString();
    }
}