using OOP_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I.Models
{
    internal class Bardak : Urun, IKirilabilir
    {
        public bool KirikMi { get ; set ; }

        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {Fiyat} KirikMi={KirikMi}";
        }
    }
}
