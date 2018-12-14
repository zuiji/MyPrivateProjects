using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Using_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);
        }
    }
}