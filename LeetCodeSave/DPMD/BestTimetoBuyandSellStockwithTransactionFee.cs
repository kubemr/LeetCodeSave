namespace LeetCodeSave.DPMD;

public class BestTimetoBuyandSellStockwithTransactionFee //65
{
    public int MaxProfit(int[] prices, int fee) {
        int profit = 0;
        int minPrice = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            else if (prices[i] > minPrice + fee)
            {
                profit += prices[i] - minPrice - fee;
                minPrice = prices[i] - fee;
            }
        }
        return profit;
    }
}