public class Solution {
    public bool IsPalindrome(string s) {
        string newArr = "";
        for(int i=0;i<s.Length;i++){
            
            if(char.IsLetterOrDigit(s[i])){
                newArr += char.ToLower(s[i]);
            }
        }
        return newArr == new string(newArr.Reverse().ToArray());
    }
}
