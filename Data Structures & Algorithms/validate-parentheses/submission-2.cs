public class Solution {
    public bool IsValid(string s) {
        if(string.IsNullOrEmpty(s) && s.Length %2 != 2) return false;
        HashSet<char> openings = new HashSet<char> {'(', '{', '['};
        HashSet<char> closing = new HashSet<char> {')', '}', ']'};
        Dictionary<char, char> di = new Dictionary<char, char> 
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        Stack<char> st = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            char c = s[i];

            if(closing.Contains(c)){
                if(st.Count == 0) return false;

                if(st.Peek() != di[c] ) return false;

                st.Pop();
            }else{
                st.Push(c);
            }
        }
        return st.Count == 0 ? true : false;
    }
}
