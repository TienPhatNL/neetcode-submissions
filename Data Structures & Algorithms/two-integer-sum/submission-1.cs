public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> value = new Dictionary<int, int>();
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (value.ContainsKey(difference))
            {
                result[0] = value[difference];
                result[1] = i;
            }
            else
            {
                value.Add(nums[i], i);
            }
        }
        return result; 
    }
}
