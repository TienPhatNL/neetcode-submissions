public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = 0, fast = 0;

        slow = nums[slow];
        fast = nums[fast];
        fast = nums[fast];

        while(slow != fast){
            slow = nums[slow];
            fast = nums[fast];
            fast = nums[fast];
        }

        slow = 0;

        while(slow != fast){
            slow = nums[slow];
            fast = nums[fast];
        }
        return fast;
    }
}
