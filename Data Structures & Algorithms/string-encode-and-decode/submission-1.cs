public class Solution {
    public string Encode(IList<string> strs) {
        string result = "";
        foreach(var s in strs){
            result += s.Length + "#" + s;
        }
        
        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int sharpIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, sharpIndex - i));
            i = sharpIndex + 1;
            result.Add(s.Substring(i, length));
            i += length;
        }
        return result;
   }
}
