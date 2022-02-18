using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Subset_Array_Simple
{
    class Program
    {
        /* Return true if arr2[] is a
    subset of arr1[] */
        static bool isSubset(int[] arr1,
                             int[] arr2,
                             int m, int n)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    if (arr2[i] == arr1[j])
                        break;

                /* If the above inner loop
                was not broken at all then
                arr2[i] is not present in
                arr1[] */
                if (j == m)
                    return false;
            }

            /* If we reach here then all
            elements of arr2[] are present
            in arr1[] */
            return true;
        }

        // Driver function
        public static void Main()
        {
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1 };

            int m = arr1.Length;
            int n = arr2.Length;

            if (isSubset(arr1, arr2, m, n))
                Console.WriteLine("arr2[] is subset"
                                  + " of arr1[] ");
            else
                Console.WriteLine("arr2[] is not a "
                                  + "subset of arr1[]");

            Console.WriteLine();
        }
    }
}
