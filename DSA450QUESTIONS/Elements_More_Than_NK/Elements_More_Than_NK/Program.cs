using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_More_Than_NK
{
    class Program
    {
        // Function to find the number of array
        // elements with frequency more than n/k times
        static void printElements(int[] arr, int n, int k)
        {

            // Calculating n/k
            int x = n / k;

            // Counting frequency of every
            // element using Counter
            Dictionary<int, int> mp
                = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (mp.ContainsKey(arr[i]))
                    mp[arr[i]] = mp[arr[i]] + 1;
                else
                    mp.Add(arr[i], 1);
            }

            foreach (KeyValuePair<int, int> entry in mp)
            {
                if (entry.Value > x)
                {
                    Console.WriteLine(entry.Key);
                }
            }
            // Traverse the map and print all
            // the elements with occurrence
            // more than n/k times
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] arr
                = { 1, 1, 2, 2, 3, 5, 4, 2, 2, 3, 1, 1, 1 };
            int n = arr.Length;
            int k = 4;

            printElements(arr, n, k);

            Console.WriteLine();
        }
    }
}
