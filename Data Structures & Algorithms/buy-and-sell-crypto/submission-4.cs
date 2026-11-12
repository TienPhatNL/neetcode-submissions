public class Solution {
    public int MaxProfit(int[] prices) {
        int bestBuy = int.MaxValue, result = 0;

        for(int i = 0; i < prices.Length; i++){
            if(bestBuy > prices[i]){
                bestBuy = prices[i];
            }

            result = Math.Max(result, (prices[i]) - bestBuy);
        }
        return result;
    }
}
