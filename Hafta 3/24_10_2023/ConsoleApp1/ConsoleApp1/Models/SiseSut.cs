using OOP_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_I.Models
{
    internal class SiseSut : Urun, ISKT, IBozuk, IKirilabilir
    {
        public DateTime SKT { get ; set; }
        public bool BozukMu { get ; set; }
        public bool KirikMi { get ;set; }

        public string BozulmaNedeni { get; set; }
        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {Fiyat} {SKT} BozukMu={BozukMu} {BozulmaNedeni} KirikMi={KirikMi}";
        }
    }
}
