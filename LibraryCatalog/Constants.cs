using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryCatalog
{
    public class Constants
    {
        public static string GetDebugImgPath()
        {
            return Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\Images\\");
        }
        public static string GetImgPath()
        {
            return $"{Directory.GetCurrentDirectory()}\\Data\\Images\\";
        }
        public static string GetDebugXMLPath()
        {
            return Directory.GetCurrentDirectory().Replace("bin\\Debug\\netcoreapp3.1", "Data\\XML\\");
        }
        public static string GetXMLPath()
        {
            return $"{Directory.GetCurrentDirectory()}\\Data\\XML\\";
        }

        public static string NoBooks { get { return "There are no books in the library yet"; } }
    }
}
