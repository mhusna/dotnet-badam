using Model.Abstract;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class Personel : Kisi
    {
        public double Maas { get; set; }
        public PersonelDurum Durum { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"- {Maas} {Durum}";
        }
    }
}
