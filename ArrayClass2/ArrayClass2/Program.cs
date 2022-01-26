
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declares an 1D Array of string.
            string[] topic;

            // allocating memory for topic.
            topic = new string[] {"Array, ", "String, ",
                              "Stack, ", "Queue, ",
                              "Exception, ", "Operators" };

            // Displaying Elements of array
            Console.WriteLine("Topic of C#:");
            Console.WriteLine();

            // Rank property provides the dimension rank
            // here we use 1-D array so it return 1
            // if we use 2-D array then it will return 2
            Console.WriteLine("Rank of the array: {0}",
                                             topic.Rank);
            foreach (string ele in topic)
                Console.WriteLine(ele + " ");
            Console.ReadLine();
        }
    }
}
