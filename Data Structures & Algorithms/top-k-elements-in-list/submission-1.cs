public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> di = new Dictionary<int, int>();

        int[] result = new int[k];

        for(int i = 0; i < nums.Length; i++){
            if(di.ContainsKey(nums[i])) di[nums[i]]++;
            else di.Add(nums[i], 1);
        }

        var order = di.OrderByDescending(x => x.Value);
        var top = order.Take(k);
        return result = top.Select(x => x.Key).ToArray();;
    }
}
