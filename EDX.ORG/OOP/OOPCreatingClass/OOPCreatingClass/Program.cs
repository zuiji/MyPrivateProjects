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
            Console.WriteLine(Math.Pow(2, 8));


            DrinksMachine myMachine = new DrinksMachine("Kitchen" , "Brand", "DM1000");
            //myMachine.Location = "kitchen"; 
            //myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);

            myMachine.MakeCappuccino();
            
        }
    }
}
