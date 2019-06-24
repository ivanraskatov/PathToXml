using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PathToXML
{
    class PathChange
    {

        public static string ReplaceName(string folderpath, string replacePart)
        {
            string newPath;
            string fakePath = @"C:\Repositories";
            
            newPath = folderpath;
            newPath = newPath.Replace(replacePart, fakePath);
            return newPath;
        }
    }
}
