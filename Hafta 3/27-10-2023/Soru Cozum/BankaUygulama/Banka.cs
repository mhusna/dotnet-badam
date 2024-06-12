using Managers.Concrete;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class Banka
    {
        public MusteriManager MusteriManager { get; set; }
        public VezneManager VezneManager { get; set; }
        public PersonelManager PersonelManager { get; set; }

        public Banka()
        {
            MusteriManager = new MusteriManager();
            VezneManager = new VezneManager();
            PersonelManager = new PersonelManager();
        }

        public bool IslemYap()
        {
            bool durum = false;

            Musteri musteri = MusteriManager.MusteriCikar();
            if (musteri != null)
            {
                foreach (Vezne vezne in VezneManager.TumunuGoster())
                {
                    if (vezne.Durum == VezneDurum.Musait)
                    {
                        vezne.Musteri = musteri;
                        Console.WriteLine(VezneManager.IslemYap(vezne));
                        durum = true;
                    }
                    else
                    {
                        Console.WriteLine("Musait vezne yok..");
                    }
                }
            }
            else
            {
                Console.WriteLine("Müşteri kalmadı..");
                durum = false;
            }

            return durum;
        }
    }
}
