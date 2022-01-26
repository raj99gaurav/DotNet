using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
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
                              "Exception, ", "Operators"};

            // Displaying Elements of the array
            Console.WriteLine("Topic of C#:");
            Console.WriteLine();

            // Here we calculate and print
            // the length of the array, i.e. 6
            Console.WriteLine("Length of the array: {0}",
                                           topic.Length);
            foreach (string ele in topic)
                Console.WriteLine(ele + " ");
            Console.ReadLine();
        }
    }
}
