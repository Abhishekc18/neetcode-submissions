public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int counter=0;
        int max=0;

        for(int i=0; i<nums.Length; i++){
            if(nums[i] == 1){
                counter++;
            }
            else{
                if(max>counter){
                    counter=0;
                }
                else{
                    max = counter;
                    counter=0;
                }
            }
        }
        if(max > counter){
            return max;
        }
        else
        {
            return counter;
        }
    }
}