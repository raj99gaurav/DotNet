using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCountAndCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an ArrayList 
            ArrayList myList = new ArrayList();

            // Adding elements to ArrayList 
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            // Displaying count of elements of ArrayList 
            Console.WriteLine("Number of elements: " + myList.Count);

            // Displaying Current capacity of ArrayList 
            Console.WriteLine("Current capacity: " + myList.Capacity);
            Console.ReadLine();
        }
    }
}
