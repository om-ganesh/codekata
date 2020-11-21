using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://www.interviewcake.com/question/python/stock-price
    /// Case1: The price is constant througout the day
    /// Case2: The price continuously decline throughout the days
    /// </summary>
    class StockPriceProfit : IProblem
    {
        List<int[]> dataset = new List<int[]>();

        public StockPriceProfit()
        {
            dataset.Add(new[] { 10, 7, 5, 8, 11, 9 });
            dataset.Add(new[] { 12, 11, 9, 7, 3 });
            dataset.Add(new[] { 11, 11, 11, 11 });
            dataset.Add(new[] { 1, 11, 3, 0, 15, 9, 2, 4, 10, 7, 12, 8 });
            dataset.Add(new[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6, 12, 14, 16, 18, 19, 17 });
            dataset.Add(new[] { 1 });
            dataset.Add(new[] { 4, 3, 2, 1 });
        }

        public void Execute()
        {
            dataset.ForEach(data =>
            {
                bool status = TryGetMaxProfit(data, out int result);
                Console.Write($"The max profit from stock prices [{string.Join(",", data)}] = ");
                if (status)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            });
        }

        private bool TryGetMaxProfit(int[] prices, out int maxProfit)
        {
            maxProfit = 0;
            if(prices.Length<2)
            {
                return false;
            }
                
            maxProfit = prices[1]-prices[0];
            int minPurchase = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                //the max. possible profit that could be made selling on current price by buying on min of previous           
                if(prices[i]-minPurchase > maxProfit)
                {
                    maxProfit = prices[i] - minPurchase;
                }

                if (prices[i] < minPurchase)
                {
                    minPurchase = prices[i];
                }

            }
            return true;
        }

        // Issue: Not able to handle the negative profit, i.e. finding minimum loss
        private int GetMaxProfit_1(int[] prices)
        {
            int maxProfit = 0;
            for(int i=0; i< prices.Length-1; i++)
            {
                //for each price check all prices thenafter to find max profit 
                for(int j =i+1; j<prices.Length;j++)
                {
                    var profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }
            return maxProfit;
        }
    }
}
