using OOP_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_I.Models
{
    internal class KagitHavlu : Urun, IBozuk
    {
        public bool BozukMu { get; set; }
        public string BozulmaNedeni { get; set; }
        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {Fiyat}  {BozukMu} {BozulmaNedeni}";
        }
    }
}
