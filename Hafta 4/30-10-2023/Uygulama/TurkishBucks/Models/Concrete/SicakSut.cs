using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class SicakSut : Urun
    {
        public string UrunAdi { get; set; } = "Sicak Sut";
        public override TimeOnly HazirlanisSuresi
        {
            get
            {
                return new TimeOnly(0, 3);
            }
        }
        public override double Fiyat { get { return 10; } }
        public override double BegenilmeOrani { get; set; }
    }
}
