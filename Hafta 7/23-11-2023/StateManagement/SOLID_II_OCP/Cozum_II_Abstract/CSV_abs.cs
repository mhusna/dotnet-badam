using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_II_OCP.Cozum_II_Abstract
{
    public class CSV_abs : Dosya
    {
        public override string DosyaOku(string path)
        {
            return "CSV data.. (Abstract)";
        }
    }
}
