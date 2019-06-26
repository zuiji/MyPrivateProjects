using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ElevCSV
{
    public static class DataSaveLocationAndFileType
    {
        public static void CreateCVSFile(List<Student> students)
        {

            // Build the file content
            var csv = new StringBuilder();
            foreach (var student in students)
            {

                var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}", student.FirstName, student.LastName, student.CprNr, student.PhoneNumber, student.Email, student.EUX, student.EducationDirection, student.GfSchool, student.WantedSkpLocation);
                csv.AppendLine(newLine);

            }

            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\elevdata.csv", csv.ToString());
        }
    }
}
