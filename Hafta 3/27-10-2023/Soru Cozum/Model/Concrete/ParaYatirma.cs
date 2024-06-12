using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class ParaYatirma : Islem
    {
        public ParaYatirma()
        {
            IslemAdi = "ParaYatirma";
            Sure = 2;
        }
        public override string Gerceklestir(Personel personel)
        {
            return "Para yatırma işlemi gerçekleştirildi.";
        }
    }
}
