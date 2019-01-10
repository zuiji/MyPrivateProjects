using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Conversions
{
    class Program
    {
        //Lecture 8: Numeric Conversions
        static void Main(string[] args)
        {
            int x = 5;
            double y = x;

            double myDouble = 5.5;

            //to force a double to an int you use (int)YourVariablesName; but you will lose some data!!!!! 
            // do what every you need to, to push it into the int. 
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);


        }
    }
}
