public class Solution {
    public bool IsValid(string s) {
        Stack<char> r = new Stack<char>();

        for(int i=0;i< s.Length;i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                r.Push(s[i]);
            }
            else{
                if(r.Count == 0) return false;
                char p = r.Pop();

                if(p == '(' && s[i] != ')') return false;
                if(p == '{' && s[i] != '}') return false;
                if(p == '[' && s[i] != ']') return false;
            }
        }

        return r.Count == 0;
    }
}