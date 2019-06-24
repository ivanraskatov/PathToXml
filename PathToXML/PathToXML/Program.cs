using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
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
            string folderPath = @"D:\test";
            string folderPath2 = @"D:\GIT REPO\LibTiff.NET";
            string folderPath3 = @"D:\GIT REPO\hardcodetWpfnotifyicon1.0.5\Hardcodet.NotifyIcon.Wpf\Source";
            string folderPathEmpty = @"D:\test2";
            string folderPathDirectories = @"D:\test3";
            string directoryName = new DirectoryInfo(folderPath2).Name;
            
            
            // Создать новый файл  xml
            String xmlFilesPath = @"D:\xmlFiles";
            String xmlPath = @"D:\GIT REPO\XmlFiles\LibTiff.NET.xml";
            Console.WriteLine(xmlPath);
            String xmlPath2 = @"D:\GIT REPO\XmlFiles\hardcodetWpfnotifyicon1.0.5";
            XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlPath, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("Sources");
            xmlTextWriter.WriteStartElement("Module");
            
            xmlTextWriter.WriteAttributeString("Name", directoryName);
            //string replacePart = Helper.GetPathReplacePart(folderPath2);
            List<string> filePathsList = new List<string>();
            string replacePart = Path.GetDirectoryName(folderPath2);
            List.GetList(folderPath2, filePathsList, xmlTextWriter, replacePart);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Close();
            Console.ReadLine();


        }
    }
}
