public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int capacity = 2 * nums.Length;

        int[] newArr = new int[capacity];

        for(int i=0;i<nums.Length;i++){
            newArr[i] = nums[i];
        }
        for(int i=0;i < nums.Length;i++){
            newArr[i + nums.Length] = nums[i];
        }

        return newArr;
    }
}