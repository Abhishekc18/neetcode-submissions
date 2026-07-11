public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = PrefixResult(nums);
        int[] suffix = SuffixResult(nums);
        int[] result = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            result[i] = prefix[i] * suffix[i];
        }
        return result;
    }
    public int[] PrefixResult(int[] nums){
        int[] prefixResult = new int[nums.Length];
        prefixResult[0] = 1;
        for(int i=1;i<nums.Length;i++){
            prefixResult[i] = prefixResult[i-1] * nums[i-1];
        }
        return prefixResult;

    }
    public int[] SuffixResult(int[] nums){
        int[] suffixResult = new int[nums.Length];
        suffixResult[nums.Length - 1] = 1;
        for(int i=nums.Length - 2;i>=0;i--){
            suffixResult[i] = suffixResult[i+1] * nums[i+1];
        }
        return suffixResult;
    }
}
