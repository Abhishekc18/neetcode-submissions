public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var list = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (nums[i] + nums[j] == target) {
                    list.Add(j);
                    list.Add(i);
                    return list.ToArray();
                }
            }
        }
        return list.ToArray();
    }
}