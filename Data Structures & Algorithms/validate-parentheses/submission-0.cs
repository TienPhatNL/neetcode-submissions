public class Solution {
    public bool IsValid(string s) {
        if(s.Length %2 != 0) return false;
        var opening = new HashSet<char>() {'(', '{', '['};
        var closing = new HashSet<char>() {')', '}', ']'};
        Dictionary<char, char> di = new Dictionary<char, char>{
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        Stack<char> st = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if(closing.Contains(c)){
                if(st.Count == 0) return false;

                if(st.Peek() != di[c]) return false;

                st.Pop();
            }else{
                st.Push(c);
            }
        }
        return st.Count == 0 ? true : false;
    }
}
