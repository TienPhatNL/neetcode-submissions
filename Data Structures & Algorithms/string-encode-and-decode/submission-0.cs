public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach(string s in strs){
            int length = s.Length;

            sb.Append($"{length}#");
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int pointer = 0;
        while(pointer < s.Length){
            int j = pointer;
            
            while(s[j] != '#'){
                j++;
            }

            int length = int.Parse(s.Substring(pointer, j-pointer));
            string decodeString = s.Substring(j+1, length);
            result.Add(decodeString);
            pointer = j+1 + length;
        }

        return result;
   }
}
