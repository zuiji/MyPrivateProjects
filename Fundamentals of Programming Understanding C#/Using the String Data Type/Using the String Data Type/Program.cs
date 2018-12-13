using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_the_String_Data_Type
{
    class Program
    {
        //Lecture 7: Using the String Data Type
        static void Main(string[] args)
        {
            string myString = "Hello World";

            string name1 = "Jesse";
            string name2 = "BoB";

            //Same thing but two dereference way to do it. 
            bool namesEqual = name1 == name2;
            Console.WriteLine("Names equal {0}", namesEqual);

            bool namesEqual1 = string.Equals(name1, name2);
            Console.WriteLine("Names equal {0}", namesEqual1);
            
            // Same thing but two dereference way to do it.
            // Compare returns numbers so if name1 = false it will give a -1 if its true its give 0 and if name2 = false its will give 1
            int namesEqual2 = string.Compare(name1, name2);
            Console.WriteLine("Names equal {0}", namesEqual2);

            int namesEqual3 = name1.CompareTo(name2);
            Console.WriteLine("Names equal {0}", namesEqual3);


            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            //substring 

            /* Name Jesse
             * J = place 0
             * E = Place 1
             * S = Place 2
             * S = place 3
             * E = place 4
             */

            string firstCharactersOfName = name1.Substring(0, 1);
            Console.WriteLine(firstCharactersOfName);

            string middleSectionOfName = name1.Substring(1, 3);
            Console.WriteLine(middleSectionOfName);

            string lastCharactersOfName = name1.Substring(4, 1);
            Console.WriteLine(lastCharactersOfName);


            //StartWith compare if the name starts with ex. Je
            bool startWith = name1.StartsWith("Je");
            Console.WriteLine(startWith);

        }

    }
}
