using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma2
{
    internal static class PersonelManager
    {
        static List<Personel> personeller = new List<Personel>();
        public static List<Personel> TumPersoneller()
        {
            return personeller;
        }

        public static Personel IdyeGorePersonel(int id)
        {
            return PersonelAra(id);
        }

        public static List<Personel> AdreseGorePersoneller(string adres)
        {
            return personeller.FindAll(p => p.Adres == adres);
        }

        public static Personel PersonelAra(int id)
        {
            return personeller.Find(p => p.PersonelID == id);
        }

        public static void PersonelEkle(string ad, string soyad, string adres)
        {
            personeller.Add(new Personel(ad, soyad, adres));
        }

        public static void PersonelSil(Personel personel)
        {
            personeller.Remove(personel);
        }

        public static void PersonelGuncelle(int id, string ad, string soyad, string adres)
        {
            Personel guncellenecekPersonel = PersonelAra(id);
            guncellenecekPersonel.PersonelAd = ad;
            guncellenecekPersonel.PersonelSoyad = soyad;
            guncellenecekPersonel.Adres = adres;
        }

        public static string PersonelBilgisiGetir(Personel personel)
        {
            return $"{personel.PersonelID} - {personel.PersonelAd} {personel.PersonelSoyad} - {personel.Adres}";
        }

        public static void PersonelYazdir(List<Personel> personeller)
        {
            foreach (Personel personel in personeller)
                Console.WriteLine(PersonelBilgisiGetir(personel));
        }

        public static void PersonelYazdir(Personel personel)
        {
            Console.WriteLine(PersonelBilgisiGetir(personel));
        }
    }
}
