using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma1
{
    internal static class YagisManager
    {
        public static bool simsekDurum = false;
        public static Yagis RastgeleYagisTipi()
        {
            List<Yagis> yagislar = new List<Yagis>()
            {
                new Yagmur(),
                new Kar(),
                new Dolu()
            };

            return yagislar[new Random().Next(0, 3)];
        }

        public static Yagis YagisOlustur(Yagis yagis)
        {
            if (yagis is Yagmur)
                return new Yagis("`");
            else if (yagis is Kar)
                return new Yagis("*");
            else
                return new Yagis("º");
        }

        public static void YagisYazdir(List<Yagis> yagislar)
        {
            foreach (Yagis yagis in yagislar)
            {
                Console.SetCursorPosition(yagis.X, yagis.Y);
                Console.Write(yagis.Karakter);
            }
        }

        public static void YagisKaydir(List<Yagis> yagislar)
        {
            yagislar = YagisKontrolEtY(yagislar);
            foreach (Yagis yagis in yagislar)
            {
                yagis.Y += 1;
                Console.Clear();
            }
        }

        public static List<Yagis> YagisKontrolEtY(List<Yagis> yagislar)
        {
            for (int i = 0; i < yagislar.Count; i++)
            {
                if (yagislar[i].Y == 29)
                {
                    YagisOlustur(new Yagis(yagislar[i].Karakter));
                    yagislar.RemoveAt(i);
                }
            }
            return yagislar;
        }

        public static List<Yagis> YagisKontrolEtX(List<Yagis> yagislar)
        {
            for (int i = 0; i < yagislar.Count; i++)
            {
                if (yagislar[i].X >= 115 || yagislar[i].X <= 5)
                {
                    YagisOlustur(new Yagis(yagislar[i].Karakter));
                    yagislar.RemoveAt(i);
                }
            }
            return yagislar;
        }

        public static void RuzgarEfekti(List<Yagis> yagislar)
        {
            int rastgeleKaydirmaSayisi = new Random().Next(3, 5);
            yagislar = YagisKontrolEtX(yagislar);

            if (rastgeleKaydirmaSayisi % 2 == 0)
            {
                foreach (Yagis yagis in yagislar)
                {
                    yagis.X += rastgeleKaydirmaSayisi;
                    Console.Clear();
                }
            }
            else
            {
                foreach (Yagis yagis in yagislar)
                {
                    yagis.X -= rastgeleKaydirmaSayisi;
                    Console.Clear();
                }
            }
        }

        public static void RastgeleRuzgarOlustur(List<Yagis> yagislar) 
        { 
            int random = new Random().Next(1, 3);
            if(DateTime.Now.Second % 2 == 0)
            {
                RuzgarEfekti(yagislar);
                Simsek();
            }
        }

        public static void Simsek()
        {
            if (simsekDurum)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                simsekDurum = false;
            }

            else
            {
                Console.ResetColor();
                simsekDurum = true;
            }
        }
    }
}
