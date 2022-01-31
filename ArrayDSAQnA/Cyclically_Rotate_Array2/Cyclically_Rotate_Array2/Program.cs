using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclically_Rotate_Array2
{
    class Program
    {
        static int[] arr = new int[] { 1, 2, 3, 4, 5 };

        // Method for rotation
        static void rotate()
        {
            int n = arr[arr.Length - 1];

            // i and j pointing to first and
            // last element respectively
            int i = 0, j = n - 1;
            while (i != j)
            {
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                i++;
            }
        }

        // Driver Code
        public static void Main()
        {
            Console.WriteLine("Given Array is");
            string Original_array = string.Join(" ", arr);
            Console.WriteLine(Original_array);

            rotate();

            Console.WriteLine("Rotated Array is");
            string Rotated_array = string.Join(" ", arr);
            Console.WriteLine(Rotated_array);

            Console.ReadLine();
        }
    }
}
