public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs == null || strs.Length == 0)
            return new List<List<string>>();

        Dictionary<string,List<string>> result = new Dictionary<string,List<string>>();
        foreach(var s in strs){
            char[] cArr = s.ToCharArray();
            Array.Sort(cArr);
            string key = new String(cArr);
            if(!result.ContainsKey(key)){
                result.Add(key, new List<string>());
            }
            result.TryGetValue(key, out var list);
            if(list != null)
                list.Add(s);
        }
        return result.Values.Cast<List<string>>().ToList();
    }
}
