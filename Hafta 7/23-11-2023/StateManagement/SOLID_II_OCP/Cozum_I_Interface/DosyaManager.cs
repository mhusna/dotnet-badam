using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_II_OCP.Cozum_I_Interface
{
    public class DosyaManager
    {
        public string Oku(IDosya dosya, string path)
        {
            return dosya.DosyadanOku(path);
        }
    }
}
