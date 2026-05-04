public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int buy = prices[0];

        for(int i = 0; i < prices.Length; i ++){
            if(buy > prices[i]){
                buy = prices[i];
            }

            int profit = prices[i] - buy;

            if(maxProfit < profit){
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}
