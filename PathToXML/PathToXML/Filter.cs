using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace PathToXML
{
    public class Filter
    {
        public static bool FolderCheck(string folderPath)
        {
            bool folderChecked = true;
            string folderName = new DirectoryInfo(folderPath).Name;
            if (folderName.Contains("Debug") || folderName.Contains("debug"))
            {
                return false;
            }
            if (folderName.IndexOf("test", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderName.IndexOf("obj", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderName.IndexOf("samples", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            Console.WriteLine(folderName + " Все хорошо");
            return folderChecked;
        }
    }
}
