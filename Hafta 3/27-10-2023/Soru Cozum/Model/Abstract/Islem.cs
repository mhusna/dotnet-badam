using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public abstract class Islem
    {
        public string IslemAdi { get; set; }
        public int Sure { get; set; }

        public abstract string Gerceklestir(Personel personel);
    }
}
