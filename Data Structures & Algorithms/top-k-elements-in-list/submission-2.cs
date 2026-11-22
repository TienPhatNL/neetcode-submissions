public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> di = new Dictionary<int, int>();

        foreach(int i in nums){
            if(di.ContainsKey(i)) di[i]++;
            else di[i] = 1;
        }
                
        var result = di.OrderByDescending(c => c.Value).Take(k);
        return result.Select(r => r.Key).ToArray();
    }
}
