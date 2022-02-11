using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Buy_Sell_Maximize_Profit_OneTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // The function assumes that there
            // are at least two elements in array.
            // The function returns a negative
            // value if the array is sorted in
            // decreasing order.Returns 0 if
            // elements are equal
            static int maxDiff(int[] arr, int arr_size)
            {
                int max_diff = arr[1] - arr[0];
                int min_element = arr[0];
                int i;
                for (i = 1; i < arr_size; i++)
                {
                    if (arr[i] - min_element > max_diff)
                        max_diff = arr[i] - min_element;
                    if (arr[i] < min_element)
                        min_element = arr[i];
                }
                return max_diff;
            }

            // Driver code
            public static void Main()
            {
                int[] arr = { 1, 2, 90, 10, 110 };
                int size = arr.Length;
                Console.Write("MaximumDifference is " +
                                       maxDiff(arr, size));
                Cpnsole.WriteLine();
            }
        }
    }
}
