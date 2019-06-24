using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Linq;



namespace PathToXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            // указать новый путь исходников библиотеки
            String[] folderPaths = new string[17];
            folderPaths[1] = @"D:\GIT REPO\LibTiff.NET";
            folderPaths[2] = @"D:\GIT REPO\hardcodetWpfnotifyicon1.0.5\Hardcodet.NotifyIcon.Wpf\Source";
            string folderPath3 = @"D:\GIT REPO\NetOffice 1.7.3\Source";
            string folderPathEmpty = @"D:\test2";
            string folderPathDirectories = @"D:\test3";
            
            String xmlFilesPath = @"D:\xmlFiles";

            // Создать новый файл  xml

            #region FolderNames
            //string directoryName = new DirectoryInfo(folderPath).Name;
            //string directoryName2 = new DirectoryInfo(folderPath2).Name;


            #endregion
            #region XmlFilePaths
            String[] xmlPaths = new string[17];
            xmlPaths[1] = @"D:\GIT REPO\XmlFiles\LibTiff.NET.xml";
            xmlPaths[2] = @"D:\GIT REPO\XmlFiles\hardcodetWpfnotifyicon1.0.5.xml";
            //xmlPaths[8] = @"D:\GIT REPO\XmlFiles\NetOffice 1.7.3.xml";

            String xmlPath = @"D:\GIT REPO\XmlFiles\LibTiff.NET.xml";
            String xmlPath2 = @"D:\GIT REPO\XmlFiles\hardcodetWpfnotifyicon1.0.5.xml";
            String xmlPath3 = @"D:\GIT REPO\XmlFiles\NetOffice 1.7.3.xml";

            #endregion

            #region Write Files


            for (int i = 1; i <= 2; i++)
            {
                XmlTextWriter xmlTextWriter = XmlWriter.Show(xmlPaths[i]);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.WriteStartElement("Sources");
                xmlTextWriter.WriteStartElement("Module");
                // Запись в xml файл
                string directoryName = new DirectoryInfo(folderPaths[i]).Name;
                xmlTextWriter.WriteAttributeString("Name", directoryName);
                List<string> filePathsList = new List<string>();
                string replacePart = Path.GetDirectoryName(folderPaths[i]);
                List.GetList(folderPaths[i], filePathsList, xmlTextWriter, replacePart);
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.Close();
            }

            

            #endregion



            Console.ReadLine();


        }
    }
}
