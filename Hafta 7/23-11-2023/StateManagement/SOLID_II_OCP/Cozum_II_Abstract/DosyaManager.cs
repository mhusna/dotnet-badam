using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_II_OCP.Cozum_II_Abstract
{
    public class DosyaManager
    {
        public string Oku(Dosya dosya, string path)
        {
            return dosya.DosyaOku(path);
        }
    }
}
