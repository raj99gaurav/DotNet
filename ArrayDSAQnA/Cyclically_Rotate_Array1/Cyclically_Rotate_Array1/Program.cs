using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclically_Rotate_Array1
{
    class Program
    {
        static int[] arr = new int[] { 1, 2, 3, 4, 5 };

        // Method for rotation
        static void rotate()
        {
            int x = arr[arr.Length - 1], i;

            for (i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];
            arr[0] = x;
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
