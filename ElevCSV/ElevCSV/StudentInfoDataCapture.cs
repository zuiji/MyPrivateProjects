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
            try
            {
                output.FirstName = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("What is your Lastname");
            try
            {
                output.LastName = Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("What is your CPR-nr");
            try
            {
                output.CprNr = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("What is your Email");
            try
            {
                output.Email = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("What is your Mobile Number");
            try
            {
                output.PhoneNumber = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Where did you take your GF2");
            try
            {
                output.GfSchool = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("What education direction do you want to go");
            output.Direction = Console.ReadLine();
           
            Console.WriteLine("Are you EUX");
            output.EUX = Console.ReadLine();
         
            Console.WriteLine("What is your wanted SKP Location?");
            output.WantedSkpLocation = Console.ReadLine();
       
            return output;

        }
    }
}
