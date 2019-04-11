using System;

namespace StaticExmple
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza margarita = new Pizza("Margarita");
            Pizza Visiu = new Pizza("Visiu");
            Pizza house = new Pizza("House");

            Console.WriteLine(margarita.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(Visiu.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(house.ToString());
            Console.WriteLine(true);
        }
    }
}
