public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> arrayS = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (arrayS.ContainsKey(c)) arrayS[c]++;
            else arrayS[c] = 1;
        }

        foreach (char c in t)
        {
            if (!arrayS.ContainsKey(c)) return false;
            else if(arrayS[c] ==1) arrayS.Remove(c); 
            else if(arrayS[c] != 1) arrayS[c]--;
        }
        return true;
    }
}
