using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{
    public abstract class AnaUrun : Urun
    {
        public abstract List<Malzeme> EkstraMalzemeler { get; set; }

        public abstract double TabanFiyat { get; set; }
        public override double Fiyat 
        {
            get
            {
                foreach (Malzeme malzeme in EkstraMalzemeler)
                    TabanFiyat += malzeme.Fiyat;
                
                return TabanFiyat;
            }
        }

        public abstract TimeSpan TabanHazirlanmaSuresi { get; set; }
        public override TimeSpan HazirlanisSuresi 
        {
            get
            {
                foreach (Malzeme malzeme in EkstraMalzemeler)
                    TabanHazirlanmaSuresi.Add(malzeme.HazirlanisSuresi);

                return TabanHazirlanmaSuresi;
            }
        }
    }
}
