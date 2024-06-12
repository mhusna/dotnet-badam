using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Kahve : AnaUrun
    {
        public string UrunAdi { get; set; }


        public override double TabanFiyat { get; set; } = 20;
        public override double Fiyat => base.Fiyat;

        public override TimeSpan TabanHazirlanmaSuresi { get; set; } = new TimeSpan(0, 10, 0);
        public override TimeSpan HazirlanisSuresi => base.HazirlanisSuresi;

        public override double BegenilmeOrani { get; }
        public override List<Malzeme> EkstraMalzemeler { get; set; }
    }
}
