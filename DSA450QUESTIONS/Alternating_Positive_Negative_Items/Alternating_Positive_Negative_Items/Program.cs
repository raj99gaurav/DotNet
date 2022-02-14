using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_Positive_Negative_Items
{
    class Program
    {
        // Function to rearrange positive and
        // negative integers in alternate fashion.
        // The below solution doesn't maintain
        // original order of elements
        static void rearrange(int[] arr, int n)
        {
            int i = 0, j = n - 1;

            // shift all negative values
            // to the end
            while (i < j)
            {
                while (i <= n - 1 && arr[i] > 0)
                    i += 1;
                while (j >= 0 && arr[j] < 0)
                    j -= 1;
                if (i < j)
                    swap(arr, i, j);
            }

            // i has index of leftmost
            // negative element
            if (i == 0 || i == n)
                return;

            // start with first positive
            // element at index 0

            // Rearrange array in alternating
            // positive & negative items
            int k = 0;
            while (k < n && i < n)
            {
                // swap next positive element
                // at even position from next
                // negative element.
                swap(arr, k, i);
                i = i + 1;
                k = k + 2;
            }
        }

        // Utility function to print an array
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }

        static void swap(int[] arr, int index1, int index2)
        {
            int c = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = c;
        }

        // Driver code
        public static void Main()
        {
            int[] arr = { 2, 3, -4, -1, 6, -9 };

            int n = arr.Length;

            Console.WriteLine("Given array is ");
            printArray(arr, n);

            rearrange(arr, n);

            Console.WriteLine("Rearranged array is ");
            printArray(arr, n);

            Console.ReadLine();
        }
    }
}
