using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ElevCSV
{
    public class DataSaveLocationAndFileType
    {
        public void CreateCVSFile(Elev elev
        )
        {
          
            // Build the file content
            var csv = new StringBuilder();

           var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", elev.FirstName, elev.LastName, elev.CprNr, elev.PhoneNumber, elev.Email, elev.EUX, elev.Direction, elev.GfSchool, elev.WantedSkpLocation);
            csv.AppendLine(newLine);

           
            File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop), csv.ToString());
        }
    }
}
