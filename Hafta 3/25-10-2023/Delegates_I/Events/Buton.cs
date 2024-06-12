using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // 1. Adım
    public delegate void OlayYakalayici();
    internal class Buton
    {
        // 2. Adım
        public event OlayYakalayici Tikla;

        // 3. Adım
        public void Calistir() 
        {
            if(Tikla != null)
                Tikla();
        }
    }
}
