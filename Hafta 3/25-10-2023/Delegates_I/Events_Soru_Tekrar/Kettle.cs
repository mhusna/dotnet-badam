using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Soru_Tekrar
{
    public delegate void Temsilci();
    internal class Kettle
    {
        public event Temsilci Kabarciklanma;
        public event Temsilci SesCikarma;
        public event Temsilci Kaynama;

        public int Derece { get; set; }
        public void Kaynat()
        {
            for (int i = 0; i <= 100; i++) 
            {
                Console.WriteLine("\n\nSuyun Derecesi: "+Derece);

                if (Derece >= 40)
                    Kabarciklanma?.Invoke();
                if (Derece >= 70)
                    SesCikarma?.Invoke();
                if (Derece >= 95)
                    Kaynama?.Invoke();

                Derece++;
            }
        }
    }
}
