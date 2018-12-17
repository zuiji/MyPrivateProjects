using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {

        //Lecture 15: If Statements
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                if (age <= 55)
                {
                    Console.WriteLine("You're good to go");
                }

            }
        }
    }
}
