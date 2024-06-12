using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ParaCekme : Islem
    {
        public override int Sure
        {
            get
            {
                return 7;
            }
        }

        public override string IslemAdi
        {
            get
            {
                return "Para Çekme";
            }
        }

        public override void IslemYap(Musteri musteri)
        {
            Console.Write("Çekilecek para: ");
            double cekilecekPara = double.Parse(Console.ReadLine());
            musteri.Hesap.Bakiye -= cekilecekPara;

            Console.WriteLine($"\n Para çekildi. Kalan bakiye: {musteri.Hesap.Bakiye}");
        }
    }
}
