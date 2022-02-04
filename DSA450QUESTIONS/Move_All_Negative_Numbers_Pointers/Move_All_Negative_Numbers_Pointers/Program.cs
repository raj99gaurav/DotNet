using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Move_All_Negative_Numbers_Pointers
{
    class Program
    {
        // Function to shift all the
        // negative elements on left side
        static void shiftall(int[] arr, int left, int right)
        {

            // Loop to iterate over the
            // array from left to the right
            while (left <= right)
            {

                // Condition to check if the left
                // and the right elements are
                // negative
                if (arr[left] < 0 && arr[right] < 0)
                    left++;

                // Condition to check if the left
                // pointer element is positive and
                // the right pointer element is negative
                else if (arr[left] > 0 && arr[right] < 0)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }

                // Condition to check if both the
                // elements are positive
                else if (arr[left] > 0 && arr[right] > 0)
                    right--;
                else
                {
                    left++;
                    right--;
                }
            }
        }

        // Function to print the array
        static void display(int[] arr, int right)
        {

            // Loop to iterate over the element
            // of the given array
            for (int i = 0; i <= right; ++i)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
        }

        // Drive code                  
        static void Main()
        {
            int[] arr = { -12, 11, -13, -5, 6, -7, 5, -3, 11 };
            int arr_size = arr.Length;
            shiftall(arr, 0, arr_size - 1);
            display(arr, arr_size - 1);
            Console.ReadLine();
        }
    }
}
