public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> di = new Dictionary<int, int>();

        int[] result = new int[2];

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];

            if(di.ContainsKey(diff)){
                result[0] = di[diff];
                result[1] = i;
            }else{
                di.Add(nums[i], i);
            }
        }
        return result;
    }
}
