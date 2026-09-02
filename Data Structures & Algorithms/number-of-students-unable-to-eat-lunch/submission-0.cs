public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int count0 = 0, count1 = 0;
        foreach (int s in students) {
            if (s == 0) count0++;
            else count1++;
        }
        foreach (int sandwich in sandwiches) {
            if (sandwich == 0 && count0 > 0) count0--;
            else if (sandwich == 1 && count1 > 0) count1--;
            else return count0 + count1;
        }
        return 0;
    }
}