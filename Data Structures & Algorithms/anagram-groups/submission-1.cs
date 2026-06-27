public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var sortedWords = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (sortedWords.TryGetValue(key, out var list))
            {
                list.Add(str);
            }
            else
            {
                sortedWords[key] = new List<string> { str };
            }
        }

        return sortedWords.Values
            .ToList();
    }
}