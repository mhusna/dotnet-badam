using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal class PersonelManager : IPersonelIslemleri
    {
        private List<Personel> _personeller = new List<Personel>();

        public List<Personel> AdreseGoreListele(string adres)
        {
            // Linq henüz anlatılmadığı için uzun yöntemle yapıyoruz.
            List<Personel> adreseGorePersoneller = new List<Personel>();
            foreach (Personel personel in _personeller)
            {
                if(personel.Adres == adres)
                    adreseGorePersoneller.Add(personel);
            }

            return adreseGorePersoneller;
        }

        public Personel Ara(int id)
        {
            // Delegates konusu henüz anlatılmadığı için uzun yöntem kullanılıyor.
            foreach (Personel personel in _personeller)
            {
                if(personel.PersonelID == id)
                    return personel;
            }

            //return null;

            // First or default tarzına döndü
            return new Personel();
        }

        public void Ekle(Personel personel)
        {
            _personeller.Add(personel);
        }

        public void Guncelle(Personel personel)
        {
            Personel guncellenecekPersonel = Ara(personel.PersonelID);

            // Bu yöntem çözümü uzatıyor. Veritabanında böyle olmaz.
            //guncellenecekPersonel.Ad = personel.Ad;
            //guncellenecekPersonel.Soyad = personel.Soyad;
            //guncellenecekPersonel.Adres = personel.Adres;

            Sil(guncellenecekPersonel.PersonelID);
            Ekle(personel);

        }

        public void Sil(int id)
        {
            _personeller.Remove(Ara(id));
        }

        public List<Personel> TumPersoneller()
        {
            return _personeller;
        }
    }
}