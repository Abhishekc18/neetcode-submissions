public class Solution {
    public string Encode(IList<string> strs) {
        string result = "";
        foreach(var s in strs){
            result += s.Length + "#" + s;
        }
        var plainTextByte = System.Text.Encoding.UTF8.GetBytes(result);
        return System.Convert.ToBase64String(plainTextByte);
    }

    public List<string> Decode(string s) {
        var base64EncodedBytes = System.Convert.FromBase64String(s);
        var str = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

        List<string> result = new List<string>();
        int i = 0;
        while (i < str.Length) {
            int sharpIndex = str.IndexOf('#', i);
            int length = int.Parse(str.Substring(i, sharpIndex - i));
            i = sharpIndex + 1;
            result.Add(str.Substring(i, length));
            i += length;
        }
        return result;
   }
}
