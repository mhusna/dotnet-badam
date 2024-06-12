using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class SogukSut : Urun
    {
        public string UrunAdi { get; set; } = "Soguk Sut";
        public override TimeOnly HazirlanisSuresi
        {
            get
            {
                return new TimeOnly(0, 1, 30);
            }
        }
        public override double Fiyat { get { return 7.5; } }
        public override double BegenilmeOrani { get; set; }
    }
}
