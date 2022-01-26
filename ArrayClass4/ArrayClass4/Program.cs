using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass4
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

            // Displaying Elements of the array before sort
            Console.WriteLine("Topic of C# before reverse:");
            Console.WriteLine();
            foreach (string ele in topic)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine();

            // using Sort() method to
            // sort the given array
            Array.Sort(topic);

            // Displaying Elements of
            // array after sort
            Console.WriteLine("Topic of C# after reverse:");
            Console.WriteLine();
            foreach (string val in topic)
            {
                Console.WriteLine(val + " ");
            }
            Console.ReadLine();
        }
    }
}
