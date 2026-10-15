public class Solution {
    public bool IsPalindrome(string s) {
        
        string s1 = s.ToLower();
        string str = "";

        foreach(char i in s1){
            if(!char.IsLetterOrDigit(i)){
                continue;
            }
            else{
                str = str + i;
            }
        }
        char[] arr = str.ToCharArray();

        Array.Reverse(arr);
        string rev = new String(arr);

        if(rev == str){
            return true;
        }else{
            return false;
        }
    }
}
