using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Using_Data
{
    class Program
    {
        // Exercise 2
        /*
         * Write a Program that asks the user for the length and width of there room. Fefine a constant
         * that represents the price of carpeting per square foot.
         * compute and display the cost of carpeting the room.
         *
         *
         *
         */
        static void Main(string[] args)
        {
            const double per_square_foot = 5.50;

            Console.WriteLine("Enther the length of your room");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of your room");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double price = area * per_square_foot;

            Console.WriteLine("The Price to carpet this {0} by {1} room is {2}", length,width,price);

        }
    }
}
