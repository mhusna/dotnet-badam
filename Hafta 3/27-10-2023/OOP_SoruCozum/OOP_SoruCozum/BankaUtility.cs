using Models.Abstract;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SoruCozum
{
    public static class BankaUtility
    {
        private static int personelID = 10;
        private static int musteriID = 1000;
        private static byte vezneNo = 65;
        private static string[] KisiOlustur()
        {
            string[] isimler = {"Cevdet", "Selami", "Dursun", "Kemal", "Deniz", "Derya", "Fuat", "Suat", "Cengiz", "Sedat", "Ayşe" };
            string[] soyisimler = { "Demir", "Aslan", "Kaplan", "Yıldırım", "Dursun", "Kara", "Irmak", "Bayrak", "Sancak", "Sert", "Ters" };

            Random random = new Random();
            string[] veriler = new string[2];
            veriler[0] = isimler[random.Next(0, isimler.Length)];
            veriler[1] = soyisimler[random.Next(0, soyisimler.Length)];

            return veriler;
        }

        public static Musteri MusteriOlustur()
        {
            Musteri musteri = new Musteri();
            musteri.ID = musteriID;
            musteriID++;

            string[] veriler = KisiOlustur();
            musteri.Ad = veriler[0];
            musteri.Soyad = veriler[1];

            musteri.IslemTipi = RastgeleIslemSec();
            musteri.HesapNo = Guid.NewGuid().ToString().Substring(0, 5);
            musteri.Bakiye = new Random().NextDouble() * 10_000;
            return musteri;
        }

        public static Personel PersonelOlustur()
        {
            Personel personel = new Personel();
            personel.ID = personelID;
            personelID++;

            string[] veriler = KisiOlustur();
            personel.Ad = veriler[0];
            personel.Soyad = veriler[1];

            return personel;
        }

        public static Vezne VezneOlustur(Personel personel)
        {
            Vezne vezne = new Vezne();
            vezne.No = ((char)vezneNo).ToString();
            vezneNo++;
            vezne.Personel = personel;
            vezne.VezneDurumu = (VezneDurumu)new Random().Next(1, 4);

            return vezne;
        }

        private static Islem RastgeleIslemSec()
        {
            List<Islem> islemler = new List<Islem>();
            islemler.Add(new HavaleIslemi() { Sure = 5 });
            islemler.Add(new ParaCekme() { Sure = 7 });
            islemler.Add(new ParaYatirma() { Sure = 2 });

            return islemler[new Random().Next(0, islemler.Count)];
        }
    }
}
