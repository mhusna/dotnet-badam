using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Events_I_SoruCozum
{
    public delegate void Temsilci(object sender);
    internal class Araba
    {
        private Lastik[] lastikler = new Lastik[4];

        public event Temsilci LastikPatladi;

        public Araba()
        {
            lastikler[0] = new PatlayanLastik() { Konum = "Sag On" };
            lastikler[1] = new PatlayanLastik() { Konum = "Sol On" };
            lastikler[2] = new PatlamayanLastik() { Konum = "Sag Arka" };
            lastikler[3] = new PatlamayanLastik() { Konum = "Sol Arka" };
        }

        public bool Sur()
        {
            Random random = new Random();

            int deger = random.Next(1, 101);
            if (deger == 99)
            {
                int hangiLastik = random.Next(0, lastikler.Length);

                if (lastikler[hangiLastik] is IPatlayabilir)
                {
                    ((IPatlayabilir)lastikler[hangiLastik]).SaglamMi = false;
                    LastikPatladi?.Invoke(lastikler[hangiLastik]);
                    return false;
                }
            }

            return true;
        }
    }
}