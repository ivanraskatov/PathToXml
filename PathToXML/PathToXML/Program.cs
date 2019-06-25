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
            folderPaths[1] = @"D:\GIT REPO\CsvHelper 7.0";
            folderPaths[2] = @"D:\GIT REPO\LibTiff.NET";
            folderPaths[3] = @"D:\GIT REPO\hardcodetWpfnotifyicon1.0.5\Hardcodet.NotifyIcon.Wpf\Source";
            folderPaths[4] = @"D:\GIT REPO\ICSharpCodeAvalonEdit-5.0.3\ICSharpCode.AvalonEdit";
            folderPaths[5] = @"D:\GIT REPO\ITfoxtecSAML-2.0";
            folderPaths[6] = @"D:\GIT REPO\MSExchangeWebServicesNETStandard-1.1.3";
            folderPaths[7] = @"D:\GIT REPO\MimeTypeMap-2.3.2";
            folderPaths[8] = @"D:\GIT REPO\NetOffice 1.7.3";
            folderPaths[9] = @"D:\GIT REPO\npgsql-4.0.2";
           

            // Создать новый файл  xml

            #region XmlFilePaths
            String[] xmlPaths = new string[17];
            xmlPaths[1] = @"D:\GIT REPO\XmlFiles\CsvHelper 7.0.xml";
            xmlPaths[2] = @"D:\GIT REPO\XmlFiles\LibTiff.NET.xml";
            xmlPaths[3] = @"D:\GIT REPO\XmlFiles\hardcodetWpfnotifyicon1.0.5.xml";
            xmlPaths[4] = @"D:\GIT REPO\XmlFiles\ICSharpCodeAvalonEdit-5.0.3.xml";
            xmlPaths[5] = @"D:\GIT REPO\XmlFiles\ITfoxtecSAML-2.0.xml";
            xmlPaths[6] = @"D:\GIT REPO\XmlFiles\MSExchangeWebServicesNETStandard-1.1.3.xml";
            xmlPaths[7] = @"D:\GIT REPO\XmlFiles\MimeTypeMap-2.3.2.xml";
            xmlPaths[8] = @"D:\GIT REPO\XmlFiles\NetOffice 1.7.3.xml";
            xmlPaths[9] = @"D:\GIT REPO\XmlFiles\npgsql-4.0.2.xml";


            #endregion
            #region Delete old .xml files from directory
            //Удаление старых xml файлов из папки,чтобы не было наложения
            DirectoryInfo deleteDirFiles = new DirectoryInfo(@"D:\GIT REPO\XmlFiles\");
            foreach (FileInfo file in deleteDirFiles.GetFiles())
            {
                file.Delete();
            }
            #endregion
            #region Write Files


            for (int i = 1; i <= 9; i++)
            {
                XmlTextWriter xmlTextWriter = XmlWriter.Show(xmlPaths[i]);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.WriteStartElement("Sources");
                xmlTextWriter.WriteStartElement("Module");



                string directoryName = new DirectoryInfo(folderPaths[i]).Name;
                xmlTextWriter.WriteAttributeString("Name", directoryName);
                List<string> filePathsList = new List<string>();
                string replacePart = Path.GetDirectoryName(folderPaths[i]);
                // Запись в xml файл
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
