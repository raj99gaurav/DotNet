//find duplicate in an array of N+1 Integers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Array_N_1_Integers
{
    class Program
    {
        static void printRepeating(int[] arr, int size)
        {
            int i, j;

            Console.Write("Repeated Elements are :");
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i] + " ");
                }
            }
        }
        // driver code
        public static void Main()
        {
            int[] arr = { 4, 2, 4, 5, 2, 3, 1 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);

            Console.WriteLine();
        }
    }
}
