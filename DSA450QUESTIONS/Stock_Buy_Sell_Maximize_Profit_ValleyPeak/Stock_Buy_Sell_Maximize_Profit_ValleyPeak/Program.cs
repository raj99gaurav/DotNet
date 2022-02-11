using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Buy_Sell_Maximize_Profit_ValleyPeak
{
    class Program
    {
        static int maxProfit(int[] prices, int size)
        {

            // maxProfit adds up the difference
            // between adjacent elements if they
            // are in increasing order
            int maxProfit = 0;

            // The loop starts from 1 as its
            // comparing with the previous
            for (int i = 1; i < size; i++)
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];

            return maxProfit;
        }

        // Driver code
        public static void Main(string[] args)
        {

            // Stock prices on consecutive days
            int[] price = { 100, 180, 260, 310, 40, 535, 695 };
            int n = price.Length;

            // Function call
            Console.WriteLine(maxProfit(price, n));
            Console.WriteLine();
        }
    }
}
