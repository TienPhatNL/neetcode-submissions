public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> di = new Dictionary<char, int>();

        foreach(char i in s){
            if(di.ContainsKey(i)) di[i]++;
            else di[i] = 1;
        }

        foreach(char c in t){
            if(!di.ContainsKey(c)) return false;

            else if (di[c] == 1) di.Remove(c);

            else if (di[c] !=  1) di[c]--;
        }

        return true;
    }
}
