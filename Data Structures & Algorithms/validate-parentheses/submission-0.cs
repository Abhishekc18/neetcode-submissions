public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();

        for(int i=0;i<s.Length;i++){
            if(s[i].Equals('(') || s[i].Equals('{') || s[i].Equals('[')){
                st.Push(s[i]);
            } else {
                if (st.Count == 0) return false;
                char top = st.Pop();
                if (s[i] == ')' && top != '(') return false;
                if (s[i] == '}' && top != '{') return false;
                if (s[i] == ']' && top != '[') return false;
            }
        }

        return st.Count == 0;
    }
}