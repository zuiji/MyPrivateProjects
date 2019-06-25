using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Elev> elevList = new List<Elev>();

            //Elev elev = 
            ElevInfoDataCapture EC = new ElevInfoDataCapture();
            DataSaveLocationAndFileType ds = new DataSaveLocationAndFileType();
            char inputFromUser = '0';
            do
            {
                Console.Clear();


               // EC.ElevCapture();
                elevList.Add(EC.ElevCapture());


                Console.WriteLine("Want to Add another student?: ");

                Console.WriteLine("1) no");
                inputFromUser = Console.ReadKey(true).KeyChar;


            } while (inputFromUser != '1');

        }
    }
}
