
// C# program to find minimum element in a sorted and rotated array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Element_Sorted_Rotated_Array
{
    class Program
    {
        static int findMin(int[] arr, int low, int high)
        {
            // This condition is needed to handle
            // the case when array
            // is not rotated at all
            if (arr[high] > arr[low])
            {
                //Console.WriteLine(" high " + high);
                //Console.WriteLine(" low " + low);
                return arr[0];
            }
            //int mid = low + (high - low) / 2;
            //Console.WriteLine("mid" + mid);
            // If there is only one element left
            if (high == low)
                return arr[low];

                // Find mid
                // (low + high)/2
                int mid = low + (high - low) / 2;

                // Check if element (mid+1) is minimum element. Consider
                // the cases like {3, 4, 5, 1, 2}
                if (mid < high && arr[mid + 1] < arr[mid])
                    return arr[mid + 1];

                // Check if mid itself is minimum element
                if (mid > low && arr[mid] < arr[mid - 1])
                    return arr[mid];

                // Decide whether we need to go to
                // left half or right half
                if (arr[high] > arr[mid])
                    return findMin(arr, low, mid - 1);
            return findMin(arr, mid + 1, high);

            
        }

        // Driver Program
        public static void Main()
        {
            int[] arr1 = { 5, 6, 1, 2, 3, 4 };
            int n1 = arr1.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr1, 0, n1 - 1));
            
            int[] arr2 = { 1, 2, 3, 4 };
            int n2 = arr2.Length;
            //Console.WriteLine(" n2 - 1 "+ (n2 - 1));
            Console.WriteLine("The minimum element is " +
                               findMin(arr2, 1, n2 - 1));
            
                int[] arr3 = { 1 };
                int n3 = arr3.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr3, 0, n3 - 1));

                int[] arr4 = { 1, 2 };
                int n4 = arr4.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr4, 0, n4 - 1));

                int[] arr5 = { 2, 1 };
                int n5 = arr5.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr5, 0, n5 - 1));

                int[] arr6 = { 5, 6, 7, 1, 2, 3, 4 };
                int n6 = arr6.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr6, 0, n1 - 1));

                int[] arr7 = { 1, 2, 3, 4, 5, 6, 7 };
                int n7 = arr7.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr7, 0, n7 - 1));

                int[] arr8 = { 2, 3, 4, 5, 6, 7, 8, 1 };
                int n8 = arr8.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr8, 0, n8 - 1));

                int[] arr9 = { 3, 4, 5, 1, 2 };
                int n9 = arr9.Length;
                Console.WriteLine("The minimum element is " +
                                   findMin(arr9, 0, n9 - 1)); 

            Console.ReadLine();
        }
    }
}
