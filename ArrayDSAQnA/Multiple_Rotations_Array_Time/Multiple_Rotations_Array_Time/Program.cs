
// C# implementation of left rotation of
// an array K number of times

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Rotations_Array_Time
{
    class Program
    {
        // Fills temp[] with two copies of arr[]
        static void preprocess(int[] arr, int n,
                                    int[] temp)
        {
            // Store arr[] elements at i and i + n
            for (int i = 0; i < n; i++)
                temp[i] = temp[i + n] = arr[i];
        }

        // Function to left rotate an array k time
        static void leftRotate(int[] arr, int n, int k,
                                        int[] temp)
        {
            // Starting position of array after k
            // rotations in temp[] will be k % n
            int start = k % n;

            // Print array after k rotations
            for (int i = start; i < start + n; i++)
                Console.Write(temp[i] + " ");
            Console.WriteLine();
        }

        // Driver program
        public static void Main()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int n = arr.Length;

            int[] temp = new int[2 * n];
            preprocess(arr, n, temp);

            int k = 2;
            leftRotate(arr, n, k, temp);

            k = 3;
            leftRotate(arr, n, k, temp);

            k = 4;
            leftRotate(arr, n, k, temp);

            Console.ReadLine();
        }
    }
}
