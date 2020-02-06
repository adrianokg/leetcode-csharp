public int MaxProfit(int[] prices) {
    int profit = 0;

    for (var i = 0; i < prices.Length - 1; i++)
    {
        if(prices[i + 1] > prices[i])
            profit += prices[i + 1] - prices[i];
    }

    return profit;
}
