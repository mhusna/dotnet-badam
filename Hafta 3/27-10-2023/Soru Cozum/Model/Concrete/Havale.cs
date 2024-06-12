using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class Havale : Islem
    {
        public Havale()
        {
            IslemAdi = "Havale";
            Sure = 5;
        }
        public override string Gerceklestir(Personel personel)
        {
            return "Havale işlemi gerçekleştirildi.";
        }
    }
}
