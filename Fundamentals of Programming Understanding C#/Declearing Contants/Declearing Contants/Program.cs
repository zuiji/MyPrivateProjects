using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declearing_Contants
{
    class Program
    {


        enum DaysOfWeek
    {
        SUNDAY, 
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    }
   
        //Lecture 9: Declaring Constants
        static void Main(string[] args)
        {
            //Cpmst you can never change a const.
            const int myConstInt = 5;

            //myConstInt = 6;
            Console.WriteLine(Math.PI);
            DaysOfWeek today = DaysOfWeek.FRIDAY;
            Console.WriteLine(today);

            int numberOfToday = (int) today;
            Console.WriteLine(numberOfToday);


        }
    }
}
