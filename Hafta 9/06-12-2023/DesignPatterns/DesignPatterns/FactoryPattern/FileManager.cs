using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class FileManager
    {
        public static Dosya CreateFile(string fileType)
        {
            if (fileType == "json")
                return new Json();
            else if (fileType == "xml")
                return new Xml();
            else 
                return null;
        }
    }
}
