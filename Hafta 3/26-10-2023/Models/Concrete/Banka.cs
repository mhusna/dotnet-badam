using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public enum Durum { Bos, Dolu}
    public enum IslemTipi { Havale, ParaYatirma, ParaCekme}
    public class Banka
    {
        public List<Musteri> Musteriler { get; set; }
        public List<Personel> Personeller { get; set; }
        public List<Banko> Bankolar { get; set; }

        public Banka()
        {
            Musteriler = new List<Musteri>();
            Personeller = new List<Personel>()
            {
                new BankoPersonel(){ Ad = "Mehmet Hüsna", Soyad = "Kışla", Durum = Durum.Bos},
                new BankoPersonel(){ Ad = "Kamil", Soyad = "Uçan", Durum = Durum.Bos}
            };

            Bankolar = new List<Banko>()
            {
                new Banko(){ BankoNo = 1, Durum = Durum.Bos, Personel = (BankoPersonel)Personeller[0], Musteri = null },
                new Banko(){ BankoNo = 2, Durum = Durum.Bos, Personel = (BankoPersonel)Personeller[1], Musteri = null }
            };
        }

        public void MusteriAl(Musteri musteri)
        {
            Musteriler.Add(musteri);
            IslemYap();
        }

        public void IslemYap()
        {
            for (int i = 0; i < Musteriler.Count; i++)
            {
                foreach (Banko banko in Bankolar)
                {
                    if (banko.Durum == Durum.Bos)
                    {
                        banko.IslemYap(Musteriler[i]);
                        break;
                    }
                }
                Musteriler.Remove(Musteriler[i]);
            }
        }
    }
}
