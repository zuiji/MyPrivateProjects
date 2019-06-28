using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ElevCSV
{
    public static class StudentInfoDataCapture
    {

        public static Student ElevCapture()
        {

            Student output = new Student();
            Console.WriteLine("What is your Firstname");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Lastname");
            output.LastName = Console.ReadLine();


            Console.WriteLine("What is your CPR-nr");
            output.CprNr = Console.ReadLine();

            Console.WriteLine("What is your Email");
            output.Email = Console.ReadLine();

            Console.WriteLine("What is your Mobile Number");
            output.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Where did you take your GF2");
            output.GfSchool = Console.ReadLine();

            Console.WriteLine("What education direction do you want to go");
            output.EducationDirection = Console.ReadLine();

            Console.WriteLine("Are you EUX");
            output.EUX = Console.ReadLine();

            Console.WriteLine("What is your wanted SKP Location?");
            output.WantedSkpLocation = Console.ReadLine();

            return output;

        }
    }
}
