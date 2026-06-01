public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> di = new Dictionary<char, int>();

        foreach(char i in s){
            if(di.ContainsKey(i)) di[i]++;
            else di[i] = 1;
        }

        foreach(char i in t){
            if(!di.ContainsKey(i)) return false;
            else if(di[i] != 1) di[i]--;
            else if(di[i] == 1) di.Remove(i);
        }

        return true;
    }
}
