using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryCatalog
{
    public class Constants
    {
        //public static string GetDebugImgPath()
        //{
        //    //C:\Users\Public\Documents\Visual Studio 2019\Projects\LibraryCatalog\LibraryCatalog\bin\Debug\net5.0 - windows
        //    string sout = Directory.GetCurrentDirectory();
        //    sout = sout.Replace(@"bin\Debug\net5.0-windows", @"Data\Images\");
        //    return sout;
        //}
        public static string GetImgPath()
        {
            return @"C:\CatalogLib\Images\";
        }
        //public static string GetDebugXMLPath()
        //{
        //    string sout = Directory.GetCurrentDirectory();
        //    sout = sout.Replace(@"bin\Debug\net5.0-windows", @"Data\XML\");
        //    return sout;
        //}
        public static string GetXMLPath()
        {
            return @"C:\CatalogLib\XML\";
        }

        public static string NoBooks { get { return "There are no books in the library yet"; } }
    }
}
