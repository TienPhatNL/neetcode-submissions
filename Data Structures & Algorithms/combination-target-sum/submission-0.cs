public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        BackTrack(0, target, new List<int>(), nums, result);
        return result;
    }

    public void BackTrack(int index, int remain, List<int> comb, int[] nums, List<List<int>> result){
        if(index >= nums.Length) return;

        if(remain < 0) return;

        comb.Add(nums[index]);

        remain = remain - nums[index];
        if(remain == 0) result.Add(new List<int>(comb));

        BackTrack(index, remain, comb, nums, result);

        comb.RemoveAt(comb.Count - 1);

        remain = remain + nums[index];

        BackTrack(index + 1, remain, comb, nums, result); 
    }
}
