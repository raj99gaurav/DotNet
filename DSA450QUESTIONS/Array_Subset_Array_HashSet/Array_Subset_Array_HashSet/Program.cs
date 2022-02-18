using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Subset_Array_HashSet
{
    class Program
    {
        static public void Main()
        {
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1 };
            int m = arr1.Length;
            int n = arr2.Length;

            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                s.Add(arr1[i]);
            }
            int p = s.Count;
            for (int i = 0; i < n; i++)
            {
                s.Add(arr2[i]);
            }

            if (s.Count == p)
            {
                Console.WriteLine("arr2[] is subset of arr1[] " + "\n");
            }
            else
            {
                Console.WriteLine("arr2[] is not subset of arr1[] " + "\n");
            }

            Console.ReadLine();
        }
    }
}
