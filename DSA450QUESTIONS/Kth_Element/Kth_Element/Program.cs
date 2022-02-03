using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Element
{
    class Program
    {
        // Function to return k'th smallest
        // element in a given array
        public static int kthSmallest(int[] arr,
                                      int k)
        {

            // Sort the given array
            Array.Sort(arr);

            // Return k'th element in
            // the sorted array
            return arr[k - 1];
        }

        // driver program
        public static void Main()
        {
            int[] arr = new int[] { 12, 3, 5,
                                7, 19 };
            int k = 2;
            Console.Write("K'th smallest element"
                          + " is " + kthSmallest(arr, k));
            Console.ReadLine();
        }
    }
}
