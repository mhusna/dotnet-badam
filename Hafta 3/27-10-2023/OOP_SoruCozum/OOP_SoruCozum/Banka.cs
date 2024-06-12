using Manager.Concrete;
using Models.Concrete;
using Models.Enums;
using OOP_SoruCozum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banka
    {
        public MusteriManager Musteriler { get; set; }
        public VezneManager Vezneler { get; set; }
        public PersonelManager Personeller { get; set; }

        public Banka()
        {
            BankaIceriginiOlustur();
        }

        private void BankaIceriginiOlustur()
        {
            Musteriler = new MusteriManager();
            Vezneler = new VezneManager();
            Personeller = new PersonelManager();

            int tekrarSayisi = new Random().Next(1, 10);
            for (int i = 0; i < tekrarSayisi; i++)
                Musteriler.Ekle(BankaUtility.MusteriOlustur());

            for (int i = 0; i < 6; i++)
                Personeller.Ekle(BankaUtility.PersonelOlustur());

            for (int i = 0; i < 5; i++)
            {
                Vezne vezne = BankaUtility.VezneOlustur(Personeller.Listele()[i]);
                vezne.VezneMusait += VezneyeMusteriAl;
                vezne.VezneDurumu = vezne.VezneDurumu;
                Vezneler.Ekle(vezne);
            }

        }

        private void VezneyeMusteriAl(object sender, EventArgs e)
        {
            Vezne vezne = sender as Vezne;
            vezne.VezneDurumu = VezneDurumu.Mesgul;
            vezne.Musteri = Musteriler.Cikar();
        }

        public void MusaitVeznelereMusteriAta()
        {
            // Tum musait veznelere musteri ata.
            foreach (Vezne vezne in Vezneler.Listele())
            {
                if (vezne.VezneDurumu == VezneDurumu.Musait)
                {
                    vezne.VezneDurumu = VezneDurumu.Mesgul;
                    vezne.Musteri = Musteriler.Cikar();
                }
            }
        }
    }
}
