using OOP_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I.Models
{
    internal class Bulgur : Urun, IBozuk,ITETT
    {
        public bool BozukMu { get; set; }
        public DateTime TETT { get; set; }
        public string BozulmaNedeni { get; set ; }

        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {Fiyat} {TETT} {BozukMu} {BozulmaNedeni}";
        }
    }
}
