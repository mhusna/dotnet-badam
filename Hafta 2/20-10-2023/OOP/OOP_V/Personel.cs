using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V
{
    public enum Gunler : byte
    {
        Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
    }
    internal class Personel
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Gunler TatilGunu { get; set; }
    }
}
