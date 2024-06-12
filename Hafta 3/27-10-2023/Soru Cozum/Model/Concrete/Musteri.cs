using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class Musteri : Kisi
    {
        public Islem Islem { get; set; }

        public Musteri()
        {
            List<Islem> islemler = new List<Islem>() { new ParaCekme(), new ParaYatirma(), new Havale()};
            Islem = islemler[new Random().Next(0, 3)];
        }

        public override string ToString()
        {
            return base.ToString() + $"{Islem}";
        }
    }
}
