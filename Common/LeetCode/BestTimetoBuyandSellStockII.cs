using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    /// <summary>
    /// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
    // On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.
    // Find and return the maximum profit you can achieve.
    /// </summary>
    public class BestTimetoBuyandSellStockII : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 122;

        public string Execute(string input)
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };

            return MaxProfit(prices).ToString();
        }

        public string GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }

        public int MaxProfit(int[] prices)
        {
            // find smallest price in input prices
            // substract neighbors prices and see if neg result. If yes then skip and proceed to next comparison
            // if positive number add to total result and proceed to next comparison.
            var totalMaxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                // check if there is next price to compare and if it's end of collection
                if (i + 1 < prices.Length)
                {
                    var currentPrice = prices[i];
                    var nextPrice = prices[i + 1];
                    var net = nextPrice - currentPrice;
                    // check if pos
                    if (net > 0)
                    {
                        totalMaxProfit += net;
                    }
                }
            }

            return totalMaxProfit;
        }
    }
}
