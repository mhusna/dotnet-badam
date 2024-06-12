using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Soru
{
    public delegate void OlayYakalayici();
    internal class Isitici
    {
        public event OlayYakalayici Kabarciklanma;
        public event OlayYakalayici SesCikarma;
        public event OlayYakalayici Kaynama;

        public int Derece { get; set; }
        public void Kaynat()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i >= 40 && Kabarciklanma != null)
                    Kabarciklanma();
                if (i >= 70 && SesCikarma != null)
                    SesCikarma();
                if (i == 100 && Kaynama != null)
                    Kaynama();

                Console.WriteLine($"Derece: {i}");
            }
        }

        // Hoca
        public void Isit()
        {
            Thread.Sleep(25);

            for (int i = 0; i < 110; i++)
            {
                if (Derece > 40)
                    Kabarciklanma?.Invoke();
                if (Derece > 70)
                    SesCikarma?.Invoke();
                if (Derece > 95)
                    Kaynama?.Invoke();
                Derece++;
            }
        }
    }
}
