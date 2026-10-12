public class Solution {
    public int ClimbStairs(int n) { 
        if(n <= 1 || n <= 2){
            return n;
        }
        int res = 1;
        int c1=1,c2=2;
        int[] arr = new int[n];

        for(int i=3;i<=n;i++){
            res = c1 + c2; //3 5 8
            c1 = c2;       //2 3 5
            c2 = res;      //3 5 8
        }
        return c2;
    }
}
