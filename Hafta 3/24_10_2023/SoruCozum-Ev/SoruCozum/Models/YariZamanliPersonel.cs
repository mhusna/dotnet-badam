using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum.Models
{
    internal class YariZamanliPersonel : Personel
    {
        public int CalismaSaati { get; set; }
        public double SaatlikUcret { get; set; }

        public override string ToString()
        {
            return $"{PersonelID} {Name} {SurName} {CalismaSaati} {SaatlikUcret}";
        }
    }
}
