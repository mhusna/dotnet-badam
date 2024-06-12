using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ParaYatirma : Islem
    {
        public override int Sure
        {
            get { return 2; }
        }

        public override string IslemAdi 
        {
            get
            {
                return "Para Yatırma";
            }
        }

        public override void IslemYap(Musteri musteri)
        {
            Console.Write("Yatırılacak para: ");
            double yatirilacakPara = double.Parse(Console.ReadLine());
            musteri.Hesap.Bakiye += yatirilacakPara;

            Console.WriteLine($"\n Para yatırıldı. Güncel bakiye: {musteri.Hesap.Bakiye}");
        }
    }
}
