using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {

        //Exercise 3
        /*
         *
         * Write a program that asks the user to enter a total amount of time in minutes only.
         * Print to the console the same amount of time in hours and minutes.
         *
         *
         *
         *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total amount of time in Minuts only");
            int totalTimeInMinuts = int.Parse(Console.ReadLine());
            int hours = totalTimeInMinuts / 60;
            int remainingMintes = totalTimeInMinuts % 60;

            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes", totalTimeInMinuts, hours, remainingMintes);
        }
    }
}
