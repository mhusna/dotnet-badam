using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Islem
    {
        public abstract int Sure { get; }
        public abstract string IslemAdi { get; }
        public abstract void IslemYap(Musteri musteri);
    }
}
