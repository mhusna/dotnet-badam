using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_II
{
    public delegate void OlayYakalayici(string lastikKonum);
    internal class Araba
    {
        public Lastik OnSolLastik { get; set; }
        public Lastik OnSagLastik { get; set; }
        public Lastik ArkaSolLastik { get; set; }
        public Lastik ArkaSagLastik { get; set; }

        public event OlayYakalayici LastikPatlama;

        public Araba()
        {
            OnSolLastik = new Lastik { LastikKonum = "On Sol" };
            OnSagLastik = new Lastik { LastikKonum = "On Sag" };
            ArkaSolLastik = new Lastik { LastikKonum = "Arka Sol" };
            ArkaSagLastik = new Lastik { LastikKonum = "Arka Sag" };
        }

        public void Sur()
        {
            while(true)
            {
                Thread.Sleep(25);
                Console.WriteLine("Gidiyor..");
                int random = new Random().Next(0, 4);
                int random2 = new Random().Next(0, 4);

                List<string> konumlar = new List<string>() { "On Sol", "On Sag", "Arka Sol", "Arka Sag" };

                if (random == random2)
                {
                    LastikPatlama?.Invoke(konumlar[random]);
                    break;
                }
            }
        }
    }
}
