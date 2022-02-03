using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort012
{
    class Program
    {
        // Sort the input array, the array is assumed to
        // have values in {0, 1, 2}
        static void sort012(int[] a, int arr_size)
        {
            int lo = 0;
            int hi = arr_size - 1;
            int mid = 0, temp = 0;

            while (mid <= hi)
            {
                switch (a[mid])
                {
                    case 0:
                        {
                            temp = a[lo];
                            a[lo] = a[mid];
                            a[mid] = temp;
                            lo++;
                            mid++;
                            break;
                        }
                    case 1:
                        mid++;
                        break;
                    case 2:
                        {
                            temp = a[mid];
                            a[mid] = a[hi];
                            a[hi] = temp;
                            hi--;
                            break;
                        }
                }
            }
        }

        /* Utility function to print array arr[] */
        static void printArray(int[] arr, int arr_size)
        {
            int i;

            for (i = 0; i < arr_size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }

        /*Driver function to check for above functions*/
        public static void Main()
        {
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int arr_size = arr.Length;
            sort012(arr, arr_size);

            Console.Write("Array after seggregation ");

            printArray(arr, arr_size);
            Console.WriteLine();
        }
    }
}
