using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Surup : Malzeme
    {
        public string UrunAdi { get; set; } = "Surup";
        public override TimeOnly HazirlanisSuresi
        {
            get
            {
                return new TimeOnly(0, 1, 45);
            }
        }
        public override double Fiyat { get { return 8; } }
        public override double BegenilmeOrani { get; }
    }
}
