public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();
        foreach (int num in nums) {
            if (dict.ContainsKey(num)){
                dict[num]++;
            } 
            else dict[num] = 1;
        }

        var sortedList = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
        
        var result = new List<int>();
        for (int i = 0; i < k; i++) {
            result.Add(sortedList[i]);
        }
        
        return result.ToArray();
    }
}