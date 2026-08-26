public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
            return 0;

        Array.Sort(nums);
        int counter = 1;
        int maxLen = 1;

        for(int i=1;i<nums.Length;i++){
            if(nums[i] == nums[i-1]){
                continue;
            }
            else if(nums[i] == nums[i-1] + 1){
                counter++;
            }
            else{
                counter=1;
            }
            maxLen = Math.Max(maxLen,counter);
        }
        return maxLen;
    }
}
