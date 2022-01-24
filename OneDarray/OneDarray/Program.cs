using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // declares a 1D Array of string.
            string[] weekDays;

            // allocating memory for days.
            weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",
                                       "Thu", "Fri", "Sat"};

            // Displaying Elements of array
            foreach (string day in weekDays)
                Console.Write(day + " ");
            Console.ReadLine();
        }
    }
}
