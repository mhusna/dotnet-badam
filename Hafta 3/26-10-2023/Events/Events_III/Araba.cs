using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_III
{
    internal class Araba
    {
        private List<Lastik> _lastikler = new List<Lastik>(4);

        public event Temsilci HasarOlustu;

        public Araba()
        {
            _lastikler.Add(new Lastik() { Konum = "Sag On" });
            _lastikler.Add(new Lastik() { Konum = "Sol On" });
            _lastikler.Add(new Lastik() { Konum = "Sag Arka" });
            _lastikler.Add(new Lastik() { Konum = "Sol Arka" });

            foreach (var item in _lastikler)
            {
                item.LastikPatladi += Item_LastikPatladi;
            }
        }

        private void Item_LastikPatladi(object sender)
        {
            HasarOlustu?.Invoke(sender);
        }

        public bool Sur()
        {
            Random random = new Random();

            int deger = random.Next(1, 101);
            if (deger == 99)
            {
                int hangiLastik = random.Next(0, _lastikler.Count);

                _lastikler[hangiLastik].Patlat();
                return false;
            }
            return true;
        }
    }
}
