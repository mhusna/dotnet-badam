using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_II_Tekrar
{
    public delegate void Temsilci(Lastik lastik);
    internal class Araba
    {
        public int Km { get; set; }
        public List<Lastik> Lastikler { get; set; }
        public event Temsilci LastikPatlamaOlayi;
        
        public Araba()
        {
            Lastikler = new List<Lastik>()
            {
                new Lastik(){ Konum = Konum.OnSag },
                new Lastik(){ Konum = Konum.OnSol },
                new Lastik(){ Konum = Konum.ArkaSag },
                new Lastik(){ Konum = Konum.ArkaSol }
            };
        }

        public void Sur()
        {
            while(true)
            {
                int random1 = new Random().Next(0, 4);
                int random2 = new Random().Next(0, 4);

                Console.WriteLine($"Gidiyor.. Kilometre: {Km}");
                if (random1 == random2)
                {
                    LastikPatlamaOlayi?.Invoke(Lastikler[random1]);
                    break;
                }
                Km++;
            }
        }
    }
}
