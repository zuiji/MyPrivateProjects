using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_the_Bool_Data_Type
{
    class Program
    {
        // Lecture 5: Using the Bool Data Type


        static void Main(string[] args)
        {
            //> >= < <= == !=
            bool myBool = true;

            bool myBool2 = 5 > 6;

            myBool2 = 6 != 6;

            Console.WriteLine(myBool2);

            int hoursWorked = 41;
            bool doesEmployeeGetOverTime = hoursWorked > 40;

            Console.WriteLine("Does employee get overtime? {0}",doesEmployeeGetOverTime);
        }
    }
}
