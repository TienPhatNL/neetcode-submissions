public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int expect = (n*(n+1)) / 2;
        int actual = 0;

        for(int i = 0; i < nums.Length; i++){
            actual+=nums[i];
        }

        return expect - actual;
    }
}
