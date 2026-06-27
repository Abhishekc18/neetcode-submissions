public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s1 = s.ToLower().ToCharArray();
        char[] t1 = t.ToLower().ToCharArray();
        
        Array.Sort(s1);
        Array.Sort(t1);

        if(s1.SequenceEqual(t1)){
            return true;
        }
        return false;
    }
}
