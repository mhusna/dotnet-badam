using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal class Personel
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{PersonelID} {Ad} {Soyad} {Adres}";
        }
    }
}