using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Banko
    {
        public BankoPersonel Personel { get; set; }
        public Musteri Musteri { get; set; }
        public int BankoNo { get; set; }
        public Durum Durum { get; set; }

        public Banko()
        {
            if (Personel == null || Personel.Durum == Durum.Dolu)
                Durum = Durum.Dolu;
        }

        public void IslemYap(Musteri musteri)
        {
            Durum = Durum.Dolu;
            Personel.Durum = Durum.Dolu;
            Musteri = musteri;

            Console.WriteLine($"Banko no: {BankoNo}");
            if (musteri.IslemTipi == IslemTipi.ParaCekme)
                new ParaCekme().IslemYap(Musteri);
            else if(musteri.IslemTipi == IslemTipi.ParaYatirma)
                new ParaYatirma().IslemYap(Musteri);
            else
                new Havale().IslemYap(Musteri);

            Durum = Durum.Bos;
            Personel.Durum = Durum.Bos;
            Musteri = null;
        }
    }
}
