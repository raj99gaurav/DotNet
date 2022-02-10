using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_Buy_Sell_Stock_Complex
{
    class Program
    {
        // Function to find maximum profit possible
        // by buying and selling at most one stack
        static int findMaximumProfit(int[] prices, int i, int k,
                                     int buy, int[,] v)
        {

            // If no stock can be chosen
            if (i >= prices.Length || k <= 0)
                return 0;

            if (v[i, buy] != -1)
                return v[i, buy];

            // If a stock is already bought
            // Buy now
            int nbuy;
            if (buy == 1)
                nbuy = 0;
            else
                nbuy = 1;
            if (buy == 1)
            {
                return v[i, buy] = Math.Max(-prices[i] +
                 findMaximumProfit(prices, i + 1, k, nbuy, v),
                 findMaximumProfit(prices, i + 1, k, (int)(buy), v));
            }

            // Otherwise
            else
            {

                // Buy now
                if (buy == 1)
                    nbuy = 0;
                else
                    nbuy = 1;
                return v[i, buy] = Math.Max(prices[i] +
                 findMaximumProfit(prices, i + 1, k - 1, nbuy, v),
                 findMaximumProfit(prices, i + 1, k, buy, v));
            }
        }

        // Function to find the maximum
        // profit in the buy and sell stock
        static int maxProfit(int[] prices)
        {
            int n = prices.Length;
            int[,] v = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                v[i, 0] = -1;
                v[i, 1] = -1;
            }

            // buy = 1 because atmost one
            // transaction is allowed
            return findMaximumProfit(prices, 0, 1, 1, v);
        }

        // Driver Code
        public static void Main()
        {

            // Given prices
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            // Function Call to find the
            // maximum profit possible by
            // buying and selling a single stock
            int ans = maxProfit(prices);

            // Print answer
            Console.Write(ans);
            Console.ReadLine();
        }
    }
}
