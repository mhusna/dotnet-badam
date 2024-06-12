using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class ParaCekme : Islem
    {
        public ParaCekme() 
        {
            IslemAdi = "ParaCekme";
            Sure = 7;
        }

        public override string Gerceklestir(Personel personel)
        {
            return "Para çekme işlemi gerçekleştirildi.";
        }
    }
}
