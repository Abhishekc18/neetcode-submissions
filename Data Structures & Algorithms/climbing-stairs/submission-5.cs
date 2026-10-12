public class Solution {
    public int ClimbStairs(int n) { 
        if(n <= 1 || n <= 2){
            return n;
        }
        int res = 1;
        int c1=1,c2=2;
        int[] arr = new int[n];

        for(int i=3;i<=n;i++){
            res = c1 + c2;
            c1 = c2;
            c2 = res;
        }
        return c2;
    }
}
