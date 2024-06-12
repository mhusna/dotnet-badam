using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Havale : Islem
    {
        public override int Sure
        {
            get
            {
                return 5;
            }
        }

        public override string IslemAdi
        {
            get
            {
                return "Havale";
            }
        }

        public override void IslemYap(Musteri musteri)
        {
            Console.Write("Havale yapıldı..");
        }
    }
}
