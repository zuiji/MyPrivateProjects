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
            List<Student> students = new List<Student>();

            char inputFromUser = '0';
            do
            {
                Console.Clear();
                
                students.Add(ElevInfoDataCapture.ElevCapture());
                
                Console.WriteLine("Want to Add another student?: ");

                Console.WriteLine("1) no");
                inputFromUser = Console.ReadKey(true).KeyChar;
                
            } while (inputFromUser != '1');
            DataSaveLocationAndFileType.CreateCVSFile(students);
        }
    }
}
