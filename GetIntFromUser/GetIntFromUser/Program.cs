using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetIntFromUser
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        static int GetIntFromUser(string Question, string Input, int Result)
        {
            Console.Write(Question + ": ");

            while (!int.TryParse(Input, out Result))
            {
                Console.Write("Invalid, Try Again: ");
                Input = Console.ReadLine();
            }

            return Result;
        }


    }
}



