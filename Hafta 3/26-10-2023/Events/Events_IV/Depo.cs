using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_IV
{
    public delegate void Temsilci(Urun urun);

    public class Depo
    {
        public int Kapasite = 100;

        public Urun[] urunler;
        public event Temsilci UrunEkleEvnt;
        public event Temsilci UrunCikarEvnt;

        public Depo()
        {
            urunler = new Urun[0];
            UrunEkleEvnt += Depo_UrunEkleEvnt;
            UrunCikarEvnt += Depo_UrunCikarEvnt;
        }

        private void Depo_UrunCikarEvnt(Urun urun)
        {
            if(urunler.Length == 0)
                Console.WriteLine("Urunler listesi boş !");
            else if(!urunler.Contains(urun))
            {
                Console.WriteLine("Böyle bir ürün yok");
            }
            else
            {
                int index = Array.IndexOf(urunler, urun);
                urunler[index] = new Urun();
                for (int i = index+1; i < urunler.Length; i++)
                {
                    urunler[i - 1] = urunler[i];
                }

                Array.Resize(ref urunler, urunler.Length - 1);
                Console.WriteLine("Urun silindi.");
            }
        }

        private void Depo_UrunEkleEvnt(Urun urun)
        {
            if (urunler.Length == Kapasite)
                Console.WriteLine("Depo dolu");
            else
            {
                Array.Resize(ref urunler, urunler.Length + 1);
                urunler[urunler.Length - 1] = urun;
                Console.WriteLine("Ürün eklendi.");
            }
        }

        public void UrunEkle(List<Urun> urunler)
        {
            foreach (Urun urun in urunler)
                UrunEkleEvnt?.Invoke(urun);
        }

        public void UrunCikar(Urun urun)
        {
            UrunCikarEvnt?.Invoke(urun);
        }

        public Urun[] TumUrunler()
        {
            return urunler;
        }
    }
}
