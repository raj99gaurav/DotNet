
// C# program to find Intersection of
// two sorted arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_Two_Sorted_Arrays
{
    class Program
    {
        /* Function prints Intersection of arr1[]
            and arr2[] m is the number of elements in arr1[]
            n is the number of elements in arr2[] */
        static void printIntersection(int[] arr1,
                                      int[] arr2, int m, int n)
        {
            int i = 0, j = 0;

            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr1[i])
                    j++;
                else
                {
                    Console.Write(arr2[j++] + " ");
                    i++;
                }
            }
        }

        // driver code
        public static void Main()
        {
            int[] arr1 = { 1, 2, 4, 5, 6 };
            int[] arr2 = { 2, 3, 5, 7 };
            int m = arr1.Length;
            int n = arr2.Length;

            printIntersection(arr1, arr2, m, n);

            Console.ReadLine();
        }
    }
}
