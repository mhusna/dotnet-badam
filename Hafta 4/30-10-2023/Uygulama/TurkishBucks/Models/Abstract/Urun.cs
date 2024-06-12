using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{
    public abstract class Urun
    {
        public string UrunAdi { get; set; }
        public abstract TimeSpan HazirlanisSuresi { get; }
        public abstract double Fiyat { get; }
        public abstract double BegenilmeOrani { get; set; }

        public override string ToString()
        {
            return $"{UrunAdi} - {HazirlanisSuresi} - {Fiyat} - {BegenilmeOrani}";
        }
    }
}
