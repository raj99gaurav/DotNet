using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Difference_Heights
{
    class Program
    {
        // Modifies the array by subtracting/adding 
        // k to every element such that the difference 
        // between maximum and minimum is minimized 
        static int getMinDiff(int[] arr, int n, int k)
        {
            if (n == 1)
                return 0;

            // Sort all elements 
            Array.Sort(arr);

            // Initialize result 
            int ans = arr[n - 1] - arr[0];

            // Handle corner elements 
            int small = arr[0] + k;
            int big = arr[n - 1] - k;
            int temp = 0;

            if (small > big)
            {
                temp = small;
                small = big;
                big = temp;
            }

            // Traverse middle elements 
            for (int i = 1; i < n - 1; i++)
            {
                int subtract = arr[i] - k;
                int add = arr[i] + k;

                // If both subtraction and  
                // addition do not change diff 
                if (subtract >= small || add <= big)
                    continue;

                // Either subtraction causes a smaller 
                // number or addition causes a greater 
                // number. Update small or big using 
                // greedy approach (If big - subtract 
                // causes smaller diff, update small 
                // Else update big) 
                if (big - subtract <= add - small)
                    small = subtract;
                else
                    big = add;
            }

            return Math.Min(ans, big - small);
        }

        // Driver Code 
        public static void Main()
        {
            int[] arr = { 4, 6 };
            int n = arr.Length;
            int k = 10;
            Console.Write("Maximum difference is " +
                            getMinDiff(arr, n, k));
            Console.ReadLine();
        }
    }
}
