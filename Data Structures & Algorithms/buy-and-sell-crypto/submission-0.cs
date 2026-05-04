public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int buy = prices[0];

        for(int right = 0; right < prices.Length; right++){
            if(buy >= prices[right]){
                buy = prices[right];
            }
            
            int profit = prices[right] - buy;

            if(maxProfit < profit){
                maxProfit = profit;
            }
            
        }

        return maxProfit;
    }
}
