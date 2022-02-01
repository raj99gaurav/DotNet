using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Value__Sum
{
    class Program
    {
        static int[] arr = new int[]{10, 1, 2, 3, 4,
                                  5, 6, 7, 8, 9};

        // Returns max possible value of i*arr[i]
        static int maxSum()
        {
            // Find array sum and i*arr[i]
            // with no rotation
            int arrSum = 0; // Stores sum of arr[i]
            int currVal = 0; // Stores sum of i*arr[i]

            for (int i = 0; i < arr.Length; i++)
            {
                arrSum = arrSum + arr[i];
                currVal = currVal + (i * arr[i]);
            }

            // Initialize result as 0 rotation sum
            int maxVal = currVal;

            // Try all rotations one by one and find
            // the maximum rotation sum.
            for (int j = 1; j < arr.Length; j++)
            {
                currVal = currVal + arrSum - arr.Length *
                                    arr[arr.Length - j];
                if (currVal > maxVal)
                    maxVal = currVal;
            }

            // Return result
            return maxVal;
        }

        // Driver Code
        public static void Main()
        {
            Console.WriteLine("Max sum is " + maxSum());
            Console.ReadLine();
        }
    }
}
