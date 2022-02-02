
// C# implementation of
// left rotation of an
// array K number of times

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Rotations_Array_Space
{
    class Program
    {
        // Function to left rotate
        // an array k times
        static void leftRotate(int[] arr,
                               int n, int k)
        {
            // Print array after
            // k rotations
            for (int i = k; i < k + n; i++)
                Console.Write(arr[i % n] + " ");
        }

        // Driver Code
        static public void Main()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int n = arr.Length;

            int k = 2;
            leftRotate(arr, n, k);
            Console.WriteLine();

            k = 3;
            leftRotate(arr, n, k);
            Console.WriteLine();

            k = 4;
            leftRotate(arr, n, k);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
