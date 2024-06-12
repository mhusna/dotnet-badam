using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum.Models
{
    internal class TamZamanliPersonel : Personel
    {
        public double TabanMaas { get; set; }

        public override string ToString()
        {
            return $"{PersonelID} {Name} {SurName} {TabanMaas}";
        }
    }
}
