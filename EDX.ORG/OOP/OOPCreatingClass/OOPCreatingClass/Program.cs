using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCreatingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine._location = "kitchen";
            myMachine._model = "DM1000";

            Console.WriteLine(myMachine._location);
            Console.WriteLine(myMachine._model);

            myMachine.MakeCappuccino();
            
        }
    }
}
