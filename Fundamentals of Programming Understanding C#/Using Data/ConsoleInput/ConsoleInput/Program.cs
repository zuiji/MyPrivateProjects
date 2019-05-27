using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    class Program
    {
        //Lecture 10: Console Input

        static void Main(string[] args)
        { 
            //    Console.WriteLine("What is your name?");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("What is your lastname");
            //    string lastname = Console.ReadLine();
            //    Console.WriteLine("Hello {0} {1} ", name, lastname);



            // how to read as a number instead of a string

            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            number += 10;
            Console.WriteLine("The new number is {0}", number);

        }
    }
}
