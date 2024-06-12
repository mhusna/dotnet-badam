using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banko
    {
        public int BankoNo { get; set; }
        public Personel Personel { get; set; }

        private bool _durum = true;
        public bool Durum
        {
            get
            {
                if (Personel == null) 
                    return false;
                return _durum;
            }
            set
            {
                _durum = value;
            }
        }
        public List<Islem> Islemler { get; }

        public Banko()
        {
            Islemler = new List<Islem>
            {
                new ParaCekme(),
                new ParaYatirma(),
                new Havale()
            };
        }

        public void MusteriAl(Musteri musteri)
        {
            Durum = false;
            Personel.Durum = false;
            Console.WriteLine($"Islem suresi: {musteri.Islem.Sure}");
            IslemYap(musteri);
        }

        public void IslemYap(Musteri musteri)
        {
            musteri.Islem.IslemYap(musteri);
            Durum = true;
            Personel.Durum = true;
        }
    }
}
