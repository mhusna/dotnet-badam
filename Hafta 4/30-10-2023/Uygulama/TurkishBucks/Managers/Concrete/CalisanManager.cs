using Managers.Abstract;
using Models.Abstract;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Concrete
{
    public class CalisanManager : IBaseManager<Calisan>
    {
        private List<Calisan> _calisanlar = new List<Calisan>(5);

        public CalisanManager()
        {
        }

        public CalisanManager(int kasadaCalisanSayisi)
        {
            List<Calisan> calisanlar = new List<Calisan>
            {
                new Calisan(){ ID = 1, Ad = "Selçuk", Soyad = "Tarimci"},
                new Calisan(){ ID = 2, Ad = "Selin", Soyad = "Odunlu"},
                new Calisan(){ ID = 3, Ad = "Atilla", Soyad = "Yapsa"},
                new Calisan(){ ID = 4, Ad = "Berfin", Soyad = "Guzel"},
                new Calisan(){ ID = 5, Ad = "Kazım", Soyad = "Katmer"}
            };

            for (int i = 0; i < _calisanlar.Count; i++)
            {
                if(i < kasadaCalisanSayisi)
                    calisanlar[i].Konum = CalisanKonum.Kasa;
                else
                    calisanlar[i].Konum = CalisanKonum.Uretim;
                Ekle(calisanlar[i]);
            }
        }

        public void Ekle(Calisan entity)
        {
            _calisanlar.Add(entity);
        }

        public List<Calisan> TumunuGetir()
        {
            return _calisanlar;
        }

        public void CalisanYerDegistir(Calisan calisan)
        {
            if (calisan.Konum == CalisanKonum.Kasa)
                calisan.Konum = CalisanKonum.Uretim;
            else
                calisan.Konum = CalisanKonum.Kasa;
        }

        public IEnumerable<Calisan> MusaitUretimcileriGetir()
        {
            foreach (Calisan calisan in _calisanlar)
            {
                if (calisan.Konum == CalisanKonum.Uretim && calisan.Durum == CalisanDurum.Musait)
                    yield return calisan;
            }
        }

        public string Uret(Siparis siparis, Calisan calisan)
        {
            calisan.Durum = CalisanDurum.Mesgul;
            // İşlemler..
            calisan.Durum = CalisanDurum.Musait;
            return $"Ürün hazırlanıyor hazırlanma süresi: {siparis.HazirlanmaSuresi}";
        }
    }
}
