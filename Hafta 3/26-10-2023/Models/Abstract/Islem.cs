using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{
    public abstract class Islem : IIslemTipi
    {
        public abstract string IslemAdi { get;}
        public abstract int Sure { get;}
        public abstract IslemTipi IslemTipi { get;}

        public virtual void IslemYap(Musteri musteri)
        {
            Console.WriteLine($"{IslemAdi} işlemi yapılıyor..");
            Console.WriteLine($"İşlem süresi: {Sure}");
        }
    }
}
