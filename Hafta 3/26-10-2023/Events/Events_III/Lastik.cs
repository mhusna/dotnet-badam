using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_III
{
    public delegate void Temsilci(object sender);
    internal class Lastik : IPatlayabilir
    {
        public string Konum { get; set; }
        public bool Saglam { get; set; } = true;
        public event Temsilci LastikPatladi;

        public void Patlat()
        {
            Saglam = false;
            LastikPatladi?.Invoke(this);
        }
    }
}
