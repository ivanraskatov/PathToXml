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
        public static void xmlWrite(XmlTextWriter xmlTextWriter, string folderPath, string replacePart)
        {
            if (Helper.AllDirectorySharpCheck(folderPath))
            {
                //Корневая папка
                xmlTextWriter.WriteStartElement("Folder");
                xmlTextWriter.WriteAttributeString("Path", Helper.XmlPathFormat(folderPath, replacePart));
                xmlTextWriter.WriteAttributeString("Description", Description.Show(folderPath));
                xmlTextWriter.WriteEndElement();
                List<string> fileNamesSortedList = Helper.FindSortSharpFiles(folderPath, replacePart);

                if (Helper.DirectorySharpCheck(folderPath))
                {
                    //Файлы в корневой папке
                    foreach (string fileName in fileNamesSortedList)
                    {
                        xmlTextWriter.WriteStartElement("File");
                        xmlTextWriter.WriteAttributeString("Path", fileName);
                        xmlTextWriter.WriteAttributeString("Description", " ");
                        xmlTextWriter.WriteEndElement();

                    }
                }
                
            }
            
            foreach (string folderName in Directory.GetDirectories(folderPath))
            {
                xmlWrite(xmlTextWriter, folderName, replacePart);
            }
        }
        static void Main(string[] args)
        {
            // указать новый путь исходников библиотеки
            string folderPath = @"D:\test";
            string folderPath2 = @"D:\GIT REPO\LibTiff.NET";
            string folderPath3 = @"D:\GIT REPO\hardcodetWpfnotifyicon1.0.5\Hardcodet.NotifyIcon.Wpf\Source";
            string folderPathEmpty = @"D:\test2";
            string folderPathDirectories = @"D:\test3";
           
            // Создать новый файл  xml
            String xmlFilesPath = @"D:\xmlFiles";
            String xmlPath = @"D:\GIT REPO\XmlFiles\libtiff.net.xml";
            String xmlPath2 = @"D:\GIT REPO\XmlFiles\hardcodetWpfnotifyicon1.0.5";
            XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlPath, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("Sources");
            xmlTextWriter.WriteStartElement("Module");
            xmlTextWriter.WriteAttributeString("Name", "linq2db");
            //xmlStartNewFile(xmlFilesPath, folderPath);
            //Helper.FindSortSharpFiles(folderPath);
            string replacePart = Helper.GetPathReplacePart(folderPath2);

            xmlWrite(xmlTextWriter, folderPath2, replacePart);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Close();
            Console.ReadLine();


        }
    }
}
