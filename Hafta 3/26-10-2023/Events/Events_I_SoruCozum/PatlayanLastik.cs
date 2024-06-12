using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_I_SoruCozum
{
    internal class PatlayanLastik : Lastik, IPatlayabilir
    {
        public bool SaglamMi { get; set; } = true;

        public override string ToString()
        {
            return Konum;
        }
    }
}
