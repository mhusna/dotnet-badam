using Managers.Concrete;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkishBucks
{
    public class KahveciDukkani
    {
        public KasaManager KasaManager { get; set; }
        public CalisanManager CalisanManager { get; set; }
        public MusteriManager MusteriManager { get; set; }

        private List<Calisan> calisanHavuzu = new List<Calisan>();

        public KahveciDukkani(int kasadaCalisacakKisiSayisi)
        {
            KasaManager = new KasaManager();
            CalisanManager = new CalisanManager(kasadaCalisacakKisiSayisi);
            MusteriManager = new MusteriManager();

            calisanHavuzu = CalisanManager.MusaitUretimcileriGetir().ToList();
        }

        public void MusteriAl(Musteri musteri)
        {
            MusteriManager.Ekle(musteri);
        }

        public void SiparisAl()
        {
            while (calisanHavuzu.Any(calisan => calisan.Durum == CalisanDurum.Musait))
            {
                Musteri sirasiGelenMusteri = MusteriManager.Cikart();
                Calisan bostakiCalisan = calisanHavuzu.Find(calisan => calisan.Durum == CalisanDurum.Musait);

                if (sirasiGelenMusteri != null)
                {
                    foreach (Kasa kasa in KasaManager.TumunuGetir())
                    {
                        if (kasa.KasaDurum == KasaDurum.Musait)
                        {
                            kasa.KasaDurum = KasaDurum.Mesgul;
                            string sonuc = KasaManager.SiparisAl(sirasiGelenMusteri, bostakiCalisan);
                            kasa.KasaDurum = KasaDurum.Musait;

                            Console.WriteLine($"{sirasiGelenMusteri.Siparis.Urunler} "+sonuc);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Musteri yok veya çalışan müsait değil.");
                    break;
                }
            }
        }
    }
}
